using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CountriesDLL
    {
        // ========== GET ALL COUNTRIES ==========
        public static async Task<List<ModelsLayer.Countries>> GetAllCountriesAsync()
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Countries.OrderBy(c => c.CountryName).ToListAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("GetAllCountriesAsync Error", ex);
                return new List<ModelsLayer.Countries>();
            }
        }

        // ========== GET COUNTRY NAMES ==========
        public static async Task<List<string>> GetCountryNamesAsync()
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Countries
                               .OrderBy(c => c.CountryName)
                               .Select(c => c.CountryName)
                               .ToListAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("GetCountryNamesAsync Error", ex);
                return new List<string>();
            }
        }

        // ========== GET COUNTRY NAME BY COUNTRY ID ==========
        public static async Task<string> GetCountryNameByCountryIDAsync(short? CountryID)
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Countries
                               .Where(c => c.CountryID == CountryID)
                               .Select(c => c.CountryName)
                               .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("GetCountryNameByCountryIDAsync Error", ex);
                return string.Empty;
            }
        }

        // ========== GET COUNTRY ID BY NAME ==========
        public static async Task<short> GetCountryIDByName(string CountryName)
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Countries
                               .Where(c => c.CountryName == CountryName)
                               .Select(c => (short)c.CountryID)
                               .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("GetCountryIDByName Error", ex);
                return 0;
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
