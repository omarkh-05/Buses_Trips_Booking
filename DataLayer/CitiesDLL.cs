using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CitiesDLL
    {
        // ========== GET CITY NAMES BY COUNTRY ID ==========
        public static async Task<List<string>> GetCityNamesByCountryIDAsync(short? CountryID)
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Cities
                               .Where(c => c.CountryID == CountryID)
                               .OrderBy(c => c.CityName)
                               .Select(c => c.CityName)
                               .ToListAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("GetCityNamesByCountryIDAsync Error", ex);
                return new List<string>();
            }
        }

        // ========== GET CITY ID BY CITY NAME ==========
        public static async Task<short> GetCityIDByCityNameAsync(string CityName)
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Cities
                               .Where(c => c.CityName == CityName)
                               .OrderBy(c => c.CityID)
                               .Select(c => c.CityID)
                               .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("GetCityIDByCityNameAsync Error", ex);
                return 0;
            }
        }

        // ========== GET CITY NAME BY CITY ID ==========
        public static async Task<string> GetCityNameByCityIDAsync(short CityID)
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Cities
                               .Where(c => c.CityID == CityID)
                               .Select(c => c.CityName)
                               .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("GetCityNameByCityIDAsync Error", ex);
                return string.Empty;
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
