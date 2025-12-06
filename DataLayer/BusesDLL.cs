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
    public class BusesDLL
    {
        // ========== ADD ==========
        public static short Add(Buses bus)
        {
            try
            {
                using var db = new AppDbContext();
                db.Buses.Add(bus);
                db.SaveChanges();
                return bus.BusID;
            }
            catch (Exception ex)
            {
                WriteEventLog("Add Buss Error", ex);
                return 0;
            }
        }

        // ========== UPDATE ==========
        public static bool Update(Buses bus)
        {
            try
            {

            using var db = new AppDbContext();

            var existing = db.Buses.FirstOrDefault(b => b.BusID == bus.BusID);
            if (existing == null) return false;

            db.Entry(existing).CurrentValues.SetValues(bus);
            return db.SaveChanges() > 0;

            }
            catch (Exception ex)
            {
                WriteEventLog("Update Buss Error", ex);
                return false;
            }
        }

        // ========== DELETE ==========
        public static bool Delete(short busID)
        {
            try
            {
            using var db = new AppDbContext();

            var existing = db.Buses.FirstOrDefault(b => b.BusID == busID);
            if (existing == null) return false;

            db.Buses.Remove(existing);
            return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                WriteEventLog("Delete Buss Error", ex);
                return false;
            }
        }

        // ========== GET ALL ==========
        public static async Task<DataTable> GetAllBuses()
        {
            try
            {
                using var db = new AppDbContext();

                var list = await db.Buses
                    .Include(b => b.Driver)
                    .Include(b => b.CreatedByUser)
                    .ToListAsync();

                DataTable dt = new DataTable();

                dt.Columns.Add("BusID", typeof(short));
                dt.Columns.Add("BusNumber", typeof(string));
                dt.Columns.Add("BusModel", typeof(string));
                dt.Columns.Add("Capacity", typeof(byte));
                dt.Columns.Add("PlateNumber", typeof(string));
                dt.Columns.Add("Status", typeof(string));

                dt.Columns.Add("DriverName", typeof(string));
                dt.Columns.Add("CreatedByUser", typeof(string));

                foreach (var b in list)
                {
                    dt.Rows.Add(
                        b.BusID,
                        b.BusNumber,
                        b.BusModel,
                        b.Capacity,
                        b.PlateNumber,
                        b.Status,
                        b.Driver?.DriverName,
                        b.CreatedByUser?.UserName
                    );
                }

                return dt;

            }
            catch (Exception ex)
            {
                WriteEventLog("Get All Buses Error", ex);
                return new DataTable();
            }
        }

        // ========== GET BY ID ==========
        public static async Task<Buses?> GetBusByID(short busID)
        {
            try
            {
                using var db = new AppDbContext();

                return await db.Buses
                    .Include(b => b.Driver)
                    .Include(b => b.CreatedByUser)
                    .FirstOrDefaultAsync(b => b.BusID == busID);
            }
            catch (Exception ex)
            {
                WriteEventLog("Get Bus By ID Error", ex);
                return null;
            }
        }

        public static async Task<List<string>> GetBusName()
        {
            try
            {
            using var db = new AppDbContext();

            return await db.Buses.Where(b => b.Status == "Ready").Select(c => c.BusNumber).ToListAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("Get Bus Name Error", ex);
                return new List<string>();
            }
        }

        public static Buses? GetBusByNumber(string busNumber)
        {
            try
            {
                using var db = new AppDbContext();

                // جلب الباص كاملاً باستخدام BusNumber
                return db.Buses.FirstOrDefault(b => b.BusNumber == busNumber);
            }
            catch (Exception ex)
            {
                WriteEventLog("Get Bus By Number Error", ex);
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
