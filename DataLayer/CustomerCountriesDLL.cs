using Microsoft.EntityFrameworkCore;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CustomerCountriesDLL
    {

        public static async Task<List<CustomersCountries>> GetAllCountries()
        {
            try
            {
                var db = new AppDbContext();
                return db.CustomersCountries
                               .OrderBy(c => c.CountryName)
                               .ToList();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Application", "An error occurred while retrieving countries: " + ex.Message);
                return new List<CustomersCountries>();
            }
        }

        public static async Task<string?> GetCountryNameById(short countryId)
        {
            try
            {
                var db = new AppDbContext();
                return await db.CustomersCountries.Where(c => c.CountryID == countryId)
                   .Select(c => c.CountryName)
                   .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Application", "An error occurred while retrieving countries: " + ex.Message);
                return "";
            }
        }
    }
}
