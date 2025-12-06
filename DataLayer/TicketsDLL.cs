using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using ModelsLayer;

namespace DataLayer
{
    public class TicketsDLL
    {
        // ================================
        //  Get All Tickets (DataTable)
        // ================================
        public static async Task<DataTable> GetAllTickets()
        {
            try
            {
                using var db = new AppDbContext();

                var list = await db.Tickets
                                   .Include(t => t.Booking)
                                   .ToListAsync();

                DataTable dt = new DataTable();

                dt.Columns.Add("TicketID", typeof(int));
                dt.Columns.Add("PassengerName", typeof(string));
                dt.Columns.Add("PassengerGender", typeof(string));
                dt.Columns.Add("NationalID", typeof(string));
                dt.Columns.Add("IssueDate", typeof(DateTime));
                dt.Columns.Add("SeatNumber", typeof(byte));
                dt.Columns.Add("QRCode", typeof(string));
                dt.Columns.Add("PersonType", typeof(string));
                dt.Columns.Add("BookingID", typeof(int));

                foreach (var t in list)
                {
                    dt.Rows.Add(
                        t.TicketID,
                        t.PassengerName,
                        t.PassengerGender,
                        t.NationalID,
                        t.IssueDate,
                        t.SeatNumber,
                        t.QRCode,
                        t.PersonType,
                        t.Booking?.BookingID
                    );
                }

                return dt;
            }
            catch (Exception ex)
            {
                WriteEventLog("GetAllTickets Error", ex);
                return new DataTable();
            }
        }

        // ================================
        //  Get Ticket By ID
        // ================================
        public static async Task<Tickets?> GetTicketByID(int ticketId)
        {
            try
            {
                using var db = new AppDbContext();

                return await db.Tickets
                               .Include(t => t.Booking)
                               .FirstOrDefaultAsync(t => t.TicketID == ticketId);
            }
            catch (Exception ex)
            {
                WriteEventLog("GetTicketByID Error", ex);
                return null;
            }
        }

        // ================================
        //  Save Tickets (Transaction)
        // ================================
        public static async Task<bool> SaveTicketsAsync(int bookingId, int tripId, List<Tickets> tickets)
        {
            using var db = new AppDbContext();
            using var transaction = await db.Database.BeginTransactionAsync();

            try
            {
                await db.Tickets.AddRangeAsync(tickets);
                await db.SaveChangesAsync();

                var trip = await db.Trips.FindAsync(tripId);
                if (trip != null)
                {
                    trip.AvailableSeats -= Convert.ToByte(tickets.Count);
                    await db.SaveChangesAsync();
                }

                await transaction.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                WriteEventLog("SaveTicketsAsync Error", ex);
                return false;
            }
        }


        public static async Task<List<byte>> AllBookedSeats(int tripId)
        {
            try
            {
                using var db = new AppDbContext();

                var seatNumbers = await db.Tickets.Where(t => t.Booking.TripID == tripId).Select(t => t.SeatNumber).ToListAsync();
                if (seatNumbers != null)
                {
                    return seatNumbers;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                WriteEventLog("AllBookedSeats Error : ", ex);
                return null;
            }
        }


        // ===================== EventLog Helper =====================
        private static void WriteEventLog(string title, Exception ex)
        {
            string error = ex.Message;
            if (ex.InnerException != null)
                error += "\nInner Exception: " + ex.InnerException.Message;

            EventLog.WriteEntry("Application", $"{title}: {error}", EventLogEntryType.Error);
        }
    }
}
