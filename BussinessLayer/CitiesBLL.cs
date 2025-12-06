using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class CitiesBLL
    {
        public static async Task<List<string>?> GetAllCitiesByCountryName(short? CountryID)
        {
            return await CitiesDLL.GetCityNamesByCountryIDAsync(CountryID);
        }

        public static async Task<short> GetCityIDByCityNameAsync(string CityName)
        {
            return await CitiesDLL.GetCityIDByCityNameAsync(CityName);
        }

        public static async Task<string> GetCityNameByCityIDAsync(short CityID)
        {
            return await CitiesDLL.GetCityNameByCityIDAsync(CityID);
        }
    }
}
