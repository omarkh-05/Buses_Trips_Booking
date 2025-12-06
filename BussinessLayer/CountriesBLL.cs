using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class CountriesBLL
    {
        public static async Task<List<string>?> GetAllCountryName()
        {
            return await CountriesDLL.GetCountryNamesAsync();
        }

        public static async Task<short> GetCountryIDByName(string countryName)
        {
            return await CountriesDLL.GetCountryIDByName(countryName);
        }

        public static async Task<string> GetCountryNameByCountryIDAsync(short? CountryID)
        {
            return await CountriesDLL.GetCountryNameByCountryIDAsync(CountryID);
        }
    }
}
