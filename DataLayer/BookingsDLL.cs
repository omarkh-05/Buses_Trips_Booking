using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace DataLayer
{
    public class BookingsDLL
    {
        // ===================== Add =====================
        public static int Add(Bookings booking)
        {
            try
            {
                using var db = new AppDbContext();

                // تحقق من وجود Trip
                var trip = db.Trips.FirstOrDefault(t => t.TripID == booking.TripID);
                if (trip == null)
                    throw new Exception("Trip not found");

                db.Bookings.Add(booking);
                db.SaveChanges();
                return booking.BookingID;
            }
            catch (Exception ex)
            {
                WriteEventLog("Add Booking Error", ex);
                return 0;
            }
        }

        // ===================== Update =====================
        public static bool Update(Bookings booking)
        {
            try
            {
                using var db = new AppDbContext();

                var existing = db.Bookings.FirstOrDefault(b => b.BookingID == booking.BookingID);
                if (existing == null)
                    throw new Exception("Booking not found");

                db.Entry(existing).CurrentValues.SetValues(booking);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                WriteEventLog("Update Booking Error", ex);
                return false;
            }
        }

        // ===================== Delete =====================
        public static bool Delete(int bookingID)
        {
            try
            {
                using var db = new AppDbContext();

                var existing = db.Bookings.FirstOrDefault(b => b.BookingID == bookingID);
                if (existing == null)
                    throw new Exception("Booking not found");

                db.Bookings.Remove(existing);
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                WriteEventLog("Delete Booking Error", ex);
                return false;
            }
        }

        // ===================== Get All Bookings =====================
        public static async Task<DataTable> GetAllBookings()
        {
            try
            {
                using var db = new AppDbContext();

                var list = await db.Bookings
                    .Include(b => b.Customer)
                    .Include(b => b.Trip)
                    .Include(b => b.CreatedByUser)
                    .Include(b => b.Ticket)
                    .Include(b => b.Payment)
                    .ToListAsync();

                DataTable dt = new DataTable();
                dt.Columns.Add("BookingID", typeof(int));
                dt.Columns.Add("TravelDate", typeof(DateTime));
                dt.Columns.Add("Class", typeof(string));
                dt.Columns.Add("AdultCount", typeof(byte));
                dt.Columns.Add("ChildCount", typeof(byte));
                dt.Columns.Add("DisabledCount", typeof(byte));
                dt.Columns.Add("PassengerCount", typeof(byte));
                dt.Columns.Add("PhoneNumber", typeof(string));
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("CreatedAt", typeof(DateTime));
                dt.Columns.Add("PaymentStatus", typeof(bool));
                dt.Columns.Add("TotalAmount", typeof(decimal));
                dt.Columns.Add("CustomerID", typeof(int));
                dt.Columns.Add("TripID", typeof(int));
                dt.Columns.Add("TravelType", typeof(string));
                dt.Columns.Add("CreatedBy", typeof(short));

                foreach (var b in list)
                {
                    dt.Rows.Add(
                        b.BookingID,
                        b.TravelDate,
                        b.Class,
                        b.AdultCount,
                        b.ChildCount,
                        b.DisabledCount,
                        b.PassengerCount,
                        b.PhoneNumber,
                        b.Status,
                        b.CreatedAt,
                        b.PaymentStatus,
                        b.TotalAmount,
                        b.CustomerID,
                        b.TripID,
                        b.TravelType,
                        b.CreatedBy
                    );
                }

                return dt;
            }
            catch (Exception ex)
            {
                WriteEventLog("GetAllBookings Error", ex);
                return new DataTable();
            }
        }
        public static async Task<List<BooksDTO>> GetAllBooksDTOForCustomer(int CustomerID)
        {
            try
            {
                using var db = new AppDbContext();

                var list = await db.Bookings
                    .Include(t => t.Trip)
                    .Where(t => t.CustomerID == CustomerID)
                    .ToListAsync();

                var bookslist = new List<BooksDTO>();
                var today = DateTime.Now.Date; // فقط التاريخ بدون الوقت

                foreach (var b in list)
                {
                    // حساب الفرق بين تاريخ السفر والتاريخ الحالي
                    var daysUntilTravel = (b.TravelDate.Date - today).Days;

                    // تحديد الحالة الجديدة
                    string dynamicStatus;
                    if (daysUntilTravel < 0)
                        dynamicStatus = "Done";
                    else if (daysUntilTravel <= 2)
                        dynamicStatus = "Soon";
                    else if (daysUntilTravel > 2)
                        dynamicStatus = "On Going";
                    else
                        dynamicStatus = "Stopped";

                    // تحديث الـ DB فقط إذا تغيرت الحالة
                    if (b.Status != dynamicStatus)
                    {
                        b.Status = dynamicStatus;
                    }

                    // بناء الـ DTO
                    bookslist.Add(new BooksDTO
                    {
                        BookingID = b.BookingID,
                        TripName = b.Trip.TripName,
                        TravelDate = b.TravelDate,
                        Class = b.Class,
                        PassengerCount = (byte)(b.AdultCount + b.ChildCount + b.DisabledCount),
                        PhoneNumber = b.PhoneNumber,
                        Status = dynamicStatus,
                        TravelType = b.TravelType,
                        PaymentStatus = b.PaymentStatus,
                        TotalAmount = b.TotalAmount
                    });
                }

                // حفظ أي تغييرات تم تعديلها
                await db.SaveChangesAsync();

                return bookslist;
            }
            catch (Exception ex)
            {
                WriteEventLog("GetAllBooksDTO Error", ex);
                return new List<BooksDTO>();
            }
        }

        // ===================== Get All Booking IDs =====================
        public static async Task<List<int>?> GetBookingAllID()
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Bookings.Select(b => b.BookingID).ToListAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("GetBookingAllID Error", ex);
                return null;
            }
        }

        // ===================== Get Booking By ID =====================
        public static async Task<Bookings?> GetBookingByID(int bookingID)
        {
            try
            {
                using var db = new AppDbContext();

                return await db.Bookings
                    .Include(b => b.Customer)
                    .Include(b => b.Trip)
                    .Include(b => b.CreatedByUser)
                    .Include(b => b.Ticket)
                    .Include(b => b.Payment)
                    .FirstOrDefaultAsync(b => b.BookingID == bookingID);
            }
            catch (Exception ex)
            {
                WriteEventLog("GetBookingByID Error", ex);
                return null;
            }
        }

        // ===================== Get Booking By Customer ID =====================
        public static async Task<List<Bookings>?> GetBookingByCustomerID(int customerId)
        {
            try
            {
                using var db = new AppDbContext();

                return await db.Bookings
                    .Include(b => b.Customer)
                    .Include(b => b.Trip)
                    .ThenInclude(t => t.Route)
                    .Include(b => b.CreatedByUser)
                    .Include(b => b.Ticket)
                    .Include(b => b.Payment)
                    .Where(b => b.CustomerID == customerId).ToListAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("GetBookingByID Error", ex);
                return null;
            }
        }


        public static async Task<bool> IsBookingOwnedByCustomer(int bookingId,int customerId)
        {
            try
            {
                using var db = new AppDbContext();
                var booking = await db.Bookings
                .Where(b => b.BookingID == bookingId && b.CustomerID == customerId)
                .FirstOrDefaultAsync();

                return booking != null;
            }
            catch (Exception ex)
            {
                WriteEventLog("GetBookingByID Error", ex);
                return false;
            }
        }

        public static async Task<bool> SaveBookingWithTicketsAndPaymentAsync(Bookings booking,List<Tickets> tickets,Payments payment)
        {
            try
            {
                using var db = new AppDbContext();
                await using var transaction = await db.Database.BeginTransactionAsync();

                // 1) Save or update Booking
                if (booking.BookingID <= 0)
                {
                    booking.CreatedAt = DateTime.Now;
                    db.Bookings.Add(booking);
                    await db.SaveChangesAsync(); // generates BookingID
                }
                else
                {
                    db.Entry(booking).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                }

                int bookingId = booking.BookingID;

                // ----------------------------------------------------
                // 2) Add Tickets  ⬅⬅⬅  (المكان الصحيح هنا)
                // ----------------------------------------------------
                if (tickets != null && tickets.Count > 0)
                {
                    foreach (var t in tickets)
                    {
                        t.BookingID = bookingId;     // important FK
                        db.Tickets.Add(t);
                    }

                    await db.SaveChangesAsync();
                }
                // ----------------------------------------------------

                // 3) Deduct seats from Trip
                var trip = await db.Trips.FirstOrDefaultAsync(x => x.TripID == booking.TripID);
                if (trip == null)
                    throw new Exception("Trip not found when updating seats.");

                if (trip.AvailableSeats < tickets.Count)
                    throw new Exception("Not enough available seats.");

                trip.AvailableSeats -= Convert.ToByte(tickets.Count);
                db.Entry(trip).State = EntityState.Modified;
                await db.SaveChangesAsync();

                // 4) Save Payment (if provided)
                if (payment != null)
                {
                    payment.BookingID = bookingId;
                    payment.TransactionDate = payment.TransactionDate == default
                                              ? DateTime.Now
                                              : payment.TransactionDate;

                    db.Payments.Add(payment);

                    // update booking payment status
                    booking.PaymentStatus = (payment.Amount >= booking.TotalAmount);
                    db.Entry(booking).State = EntityState.Modified;

                    await db.SaveChangesAsync();
                }

                await transaction.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                WriteEventLog("SaveBookingWithTicketsAndPaymentAsync Error :" , ex);
                // log if needed
                return false;
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
