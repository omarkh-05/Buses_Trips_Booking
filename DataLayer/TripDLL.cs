using Microsoft.EntityFrameworkCore;
using ModelsLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TripDLL
    {
        // ===================== Add =====================
        public static int Add(Trips trip)
        {
            try
            {
                using var db = new AppDbContext();

                // اجلب الباص
                var bus = db.Buses.FirstOrDefault(b => b.BusID == trip.BusID);
                if (bus == null)
                    throw new Exception("Bus not found");

                // المقاعد المتاحة = سعة الباص
                trip.AvailableSeats = bus.Capacity;

                db.Trips.Add(trip);
                db.SaveChanges();
                return trip.TripID;
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage += "\nInner Exception: " + ex.InnerException.Message;
                }

                // تسجيل الخطأ مع الاستثناء الداخلي في سجل الأحداث
                EventLog.WriteEntry("Application", "Add Trip Error: " + errorMessage, EventLogEntryType.Error);
                return 0;
            }
        }

        // ===================== Update =====================
        public static bool Update(Trips trip)
        {
            try
            {
                using var db = new AppDbContext();

                var existing = db.Trips.FirstOrDefault(t => t.TripID == trip.TripID);
                if (existing == null)
                    throw new Exception("Trip not found");

                db.Entry(existing).CurrentValues.SetValues(trip);
                return true;
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage += "\nInner Exception: " + ex.InnerException.Message;
                }

                EventLog.WriteEntry("Application", "Update Trip Error" + errorMessage, EventLogEntryType.Error);
                return false;
            }
        }

        // ===================== Delete =====================
        public static bool Delete(int tripID)
        {
            try
            {
                using var db = new AppDbContext();

                var existing = db.Trips.FirstOrDefault(t => t.TripID == tripID);
                if (existing == null)
                    throw new Exception("Trip not found");

                db.Trips.Remove(existing);
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage += "\nInner Exception: " + ex.InnerException.Message;
                }


                WriteEventLog("Delete Trip Error", ex);
                return false;
            }
        }

        // ===================== Get All Trips =====================
        public static async Task<DataTable> GetAllTrips()
        {
            try
            {
                using var db = new AppDbContext();

                var list = await db.Trips
                    .Include(t => t.Route)
                    .Include(t => t.Bus)
                    .Include(t => t.CreatedByUser)
                    .ToListAsync();

                DataTable dt = new DataTable();
                dt.Columns.Add("TripID", typeof(int));
                dt.Columns.Add("IsInternational", typeof(bool));
                dt.Columns.Add("TripDate", typeof(DateTime));
                dt.Columns.Add("DepartureTime", typeof(string));
                dt.Columns.Add("ArrivalTime", typeof(string));
                dt.Columns.Add("Price", typeof(decimal));
                dt.Columns.Add("AvailableSeats", typeof(byte));
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Route", typeof(string));
                dt.Columns.Add("Bus", typeof(string));
                dt.Columns.Add("TripName", typeof(string));
                dt.Columns.Add("Class", typeof(string));
                dt.Columns.Add("CreatedByUser", typeof(string));

                foreach (var t in list)
                {
                    dt.Rows.Add(
                        t.TripID,
                        t.IsInternational,
                        t.TripDate,
                        t.DepartureTime.ToString(),
                        t.ArrivalTime.ToString(),
                        t.Price,
                        t.AvailableSeats,
                        t.Status,
                        t.Route?.RouteID.ToString(),
                        t.Bus?.BusNumber,
                        t.TripName,
                        t.Class,
                        t.CreatedByUser?.UserName
                    );
                }

                return dt;
            }
            catch (Exception ex)
            {
                WriteEventLog("GetAllTrips Error", ex);
                return new DataTable();
            }
        }
        public static List<TripDTO> GetAllDTOTrips()
        {
            try
            {
                using var db = new AppDbContext();

                var list = db.Trips
                    .Include(t => t.Route)
                    .Include(t => t.Bus)
                    .Include(t => t.CreatedByUser)
                    .ToList();

                // قائمة من TripDTO
                var tripsList = new List<TripDTO>();

                foreach (var t in list)
                {
                    tripsList.Add(new TripDTO
                    {
                        TripID = t.TripID,
                        IsInternational = t.IsInternational,
                        TripDate = t.TripDate,
                        DepartureTime = t.DepartureTime.ToString(),
                        ArrivalTime = t.ArrivalTime.ToString(),
                        Price = t.Price,
                        AvailableSeats = t.AvailableSeats,
                        Status = t.Status,
                        Route = t.Route?.RouteID.ToString(),
                        Bus = t.Bus?.BusNumber,
                        TripName = t.TripName,
                        Class = t.Class,
                        CreatedByUser = t.CreatedByUser?.UserName
                    });
                }

                return tripsList;
            }
            catch (Exception ex)
            {
                WriteEventLog("GetAllTrips Error", ex);
                return new List<TripDTO>(); // إرجاع قائمة فارغة في حال حدوث خطأ
            }
        }
        
        // ===================== Get TripDTO By Name =====================
        public static async Task<TripDTO> GetTripDTOByName(string TripName)
        {
            try
            {
                using var db = new AppDbContext();

                var trip = await db.Trips
                    .Include(t => t.Route)
                    .Include(t => t.Bus)
                    .Include(t => t.CreatedByUser)
                    .FirstOrDefaultAsync(t => t.TripName == TripName);

                if (trip == null)
                    return null;

                // قائمة من TripDTO
                var tripDTO = new TripDTO
                {
                    TripID = trip.TripID,
                    IsInternational = trip.IsInternational,
                    TripDate = trip.TripDate,
                    DepartureTime = trip.DepartureTime.ToString(),
                    ArrivalTime = trip.ArrivalTime.ToString(),
                    Price = trip.Price,
                    AvailableSeats = trip.AvailableSeats,
                    Status = trip.Status,
                    Route = trip.Route?.RouteID.ToString(),
                    Bus = trip.Bus?.BusNumber,
                    TripName = trip.TripName,
                    Class = trip.Class,
                    CreatedByUser = trip.CreatedByUser?.UserName
                };

                return tripDTO;
            }
            catch (Exception ex)
            {
                WriteEventLog("GetAllTrips Error", ex);
                return null; // إرجاع قائمة فارغة في حال حدوث خطأ
            }
        }

        // ===================== Get All Trip IDs =====================
        public static async Task<List<int>?> GetTripAllID()
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Trips.Select(t => t.TripID).ToListAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("GetTripAllID Error", ex);
                return null;
            }
        }

        // ===================== Get Trip By ID =====================
        public static async Task<Trips?> GetTripByID(int tripID)
        {
            try
            {
                using var db = new AppDbContext();

                return await db.Trips
                    .Include(t => t.Route)
                    .Include(t => t.Bus)
                    .Include(t => t.CreatedByUser)
                    .FirstOrDefaultAsync(t => t.TripID == tripID);
            }
            catch (Exception ex)
            {
                WriteEventLog("GetTripByID Error", ex);
                return null;
            }
        }

        // ===================== Get Trip By Name =====================
        public static async Task<Trips?> GetTripByName(string TripName)
        {
            try
            {
                using var db = new AppDbContext();

                return await db.Trips
                    .Include(t => t.Route)
                    .Include(t => t.Bus)
                    .Include(t => t.CreatedByUser)
                    .FirstOrDefaultAsync(t => t.TripName == TripName);
            }
            catch (Exception ex)
            {
                WriteEventLog("GetTripByID Error", ex);
                return null;
            }
        }


        public static async Task<int> GetTripIDByName(string tripName)
        {
            int TripID = 0;
            try
            {
                using var db = new AppDbContext();

                TripID = await db.Trips.Where(t => t.TripName == tripName)
                    .Select(t =>t.TripID).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("GetTripIDByName Error", ex);
            }
            return TripID;
        }
        public static async Task<List<string>> GetInterNationalTripsName()
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Trips
                    .Where(t => t.IsInternational == true && t.Status == "On Going")
                    .Select(t => t.TripName)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("InterGetNationalTripsName Error", ex);
                return new List<string>();
            }
        }
        public static async Task<List<string>> GetNationalTripsName()
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Trips
                    .Where(t => t.IsInternational == false && t.Status == "On Going")
                    .Select(t => t.TripName)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("GetNationalTripsName Error", ex);
                return new List<string>();
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
