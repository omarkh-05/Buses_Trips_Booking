using Microsoft.EntityFrameworkCore;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TripTimesDLL
    {
        private  readonly AppDbContext _context;

        public TripTimesDLL(AppDbContext context)
        {
            _context = context;
        }

        //public static async Task<List<TripTimes>> GetAllTripTimes()
        //{
        //    using var db = new AppDbContext();
        //    return await db.TripTimes
        //                         .OrderBy(tt => tt.Time)
        //                         .ToListAsync();
        //}

        // 1️⃣ جلب كل أوقات رحلة معينة
        public static async Task<List<TripTimes>> GetTripTimesByTripIdAsync(int tripTimeId)
       {
            using var db = new AppDbContext();
           return await db.TripTimes
                                .Where(tt => tt.TripTimeID == tripTimeId)
                                .OrderBy(tt => tt.TripTimeID)
                                .ToListAsync();
       }

        //// 2️⃣ جلب وقت رحلة محدد (مثلاً للعرض أو التحقق)
        //public async Task<TripTimes?> GetTripTimeByIdAsync(int tripTimeId)
        //{
        //    return await _context.TripTimes
        //                         .Include(tt => tt.Trip)
        //                         .FirstOrDefaultAsync(tt => tt.TripTimeID == tripTimeId);
        //}

        //// 3️⃣ إضافة وقت جديد لرحلة
        //public async Task<TripTimes> AddTripTimeAsync(int tripId, TimeSpan time)
        //{
        //    var tripTime = new TripTimes
        //    {
        //        TripID = tripId,
        //        Time = time
        //    };
        //    _context.TripTimes.Add(tripTime);
        //    await _context.SaveChangesAsync();
        //    return tripTime;
        //}

        //// 4️⃣ تحديث وقت موجود
        //public async Task<bool> UpdateTripTimeAsync(int tripTimeId, TimeSpan newTime)
        //{
        //    var tripTime = await _context.TripTimes.FindAsync(tripTimeId);
        //    if (tripTime == null) return false;
        //    tripTime.Time = newTime;
        //    await _context.SaveChangesAsync();
        //    return true;
        //}

        //// 5️⃣ حذف وقت رحلة
        //public async Task<bool> DeleteTripTimeAsync(int tripTimeId)
        //{
        //    var tripTime = await _context.TripTimes.FindAsync(tripTimeId);
        //    if (tripTime == null) return false;
        //    _context.TripTimes.Remove(tripTime);
        //    await _context.SaveChangesAsync();
        //    return true;
        //}

    }
}
