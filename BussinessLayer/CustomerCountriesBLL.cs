using DataLayer;
using Microsoft.EntityFrameworkCore;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class CustomerCountriesBLL
    {
        public static async Task<List<CustomersCountries>> GetCountries()
        {
            return await CustomerCountriesDLL.GetAllCountries();
        }
    }
}
