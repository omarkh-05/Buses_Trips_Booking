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
    public class TripTimesBLL
    {
       public static async Task<List<TripTimes>> GetAllTripTimes(short tripTimeId)
       {
           return await TripTimesDLL.GetTripTimesByTripIdAsync(tripTimeId);
       }
    }
}
