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
    public class DriversDLL
    {
        // ========== ADD DRIVER ==========
        public static short Add(Drivers driver)
        {
            try
            {
                using var db = new AppDbContext();
                db.Drivers.Add(driver);
                db.SaveChanges();
                return driver.DriverID;
            }
            catch (Exception ex)
            {
                WriteEventLog("Add Driver Error", ex);
                return 0;
            }
        }

        // ========== UPDATE DRIVER ==========
        public static bool Update(Drivers driver)
        {
            try
            {
                using var db = new AppDbContext();
                var existing = db.Drivers.FirstOrDefault(d => d.DriverID == driver.DriverID);
                if (existing == null) return false;

                db.Entry(existing).CurrentValues.SetValues(driver);
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                WriteEventLog("Update Driver Error", ex);
                return false;
            }
        }

        // ========== DELETE DRIVER ==========
        public static bool Delete(short driverId)
        {
            try
            {
                using var db = new AppDbContext();
                var existing = db.Drivers.FirstOrDefault(d => d.DriverID == driverId);
                if (existing == null) return false;

                db.Drivers.Remove(existing);
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                WriteEventLog("Delete Driver Error", ex);
                return false;
            }
        }

        // ========== GET ALL DRIVERS ==========
        public static async Task<DataTable> GetAllDrivers()
        {
            try
            {
                using var db = new AppDbContext();
                var list = await db.Drivers.Include(d => d.CreatedByUser).ToListAsync();

                DataTable dt = new DataTable();
                dt.Columns.Add("DriverID", typeof(short));
                dt.Columns.Add("DriverName", typeof(string));
                dt.Columns.Add("DriverRank", typeof(string));
                dt.Columns.Add("CreatedByUser", typeof(string));

                foreach (var d in list)
                {
                    dt.Rows.Add(d.DriverID, d.DriverName, d.DriverRank, d.CreatedByUser?.UserName);
                }

                return dt;
            }
            catch (Exception ex)
            {
                WriteEventLog("GetAllDrivers Error", ex);
                return new DataTable();
            }
        }

        // ========== GET ALL DRIVER IDs ==========
        public static async Task<List<short>?> GetDriverAllID()
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Drivers.Select(d => d.DriverID).ToListAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("GetDriverAllID Error", ex);
                return new List<short>();
            }
        }

        // ========== GET DRIVER BY ID ==========
        public static async Task<Drivers?> GetDriverByID(short driverId)
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Drivers.Include(d => d.CreatedByUser)
                                       .FirstOrDefaultAsync(d => d.DriverID == driverId);
            }
            catch (Exception ex)
            {
                WriteEventLog("GetDriverByID Error", ex);
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
