using Microsoft.EntityFrameworkCore;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PaymentsDLL
    {
        public static async Task<DataTable> GetAllPayments()
        {
            try
            {
                using var db = new AppDbContext();
                //  the include statements to load related entities Only For Nacigation Properties
                var list = await db.Payments.Include(r => r.Booking)
                                          .ToListAsync();

                DataTable dt = new DataTable();
                dt.Columns.Add("PaymentID", typeof(int));
                dt.Columns.Add("Amount", typeof(decimal));
                dt.Columns.Add("PaymentMethod", typeof(string));
                dt.Columns.Add("TransactionDate", typeof(DateTime));
                dt.Columns.Add("IsRefunded", typeof(bool));
                dt.Columns.Add("BookingID", typeof(int));

                foreach (var p in list)
                {
                    dt.Rows.Add(p.PaymentID, p.Amount, p.PaymentMethod, p.TransactionDate, p.IsRefunded, p.Booking.BookingID);
                }

                return dt;
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                if (ex.InnerException != null)
                    errorMessage += "\nInner Exception: " + ex.InnerException.Message;
                EventLog.WriteEntry("Application", "GetAllPayments Error: " + errorMessage, EventLogEntryType.Error);
                return new DataTable(); // Return an empty DataTable in case of error
            }
        }

        public static async Task<Payments?> GetPaymentByID(int PaymentId)
        {
            try
            {
                using var db = new AppDbContext();

                return await db.Payments
                               .Include(c => c.Booking)
                               .FirstOrDefaultAsync(c => c.PaymentID == PaymentId);
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                if (ex.InnerException != null)
                    errorMessage += "\nInner Exception: " + ex.InnerException.Message;

                EventLog.WriteEntry("Application", "GetPaymentByID Error: " + errorMessage, EventLogEntryType.Error);

                return null;
            }
        }


        public static async Task<bool> UpdateRefund(int paymentId)
        {
            try
            {
                using var db = new AppDbContext();

                var payment = await db.Payments
                                      .FirstOrDefaultAsync(p => p.PaymentID == paymentId);

                if (payment != null)
                {
                    payment.IsRefunded = true;
                    await db.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                if (ex.InnerException != null)
                    errorMessage += "\nInner Exception: " + ex.InnerException.Message;
                EventLog.WriteEntry("Application", "UpdateRefund Error: " + errorMessage, EventLogEntryType.Error);
                return false;

            }
        }

        public static bool Save(Payments payment)
        {
            using var db = new AppDbContext();
            using var transaction = db.Database.BeginTransaction();

            try
            {
                // تأكد من وجود البوكينج
                var booking = db.Bookings.FirstOrDefault(b => b.BookingID == payment.BookingID);
                if (booking == null)
                    throw new Exception("Booking not found");

                // إصلاح قيمة IsRefunded
                payment.IsRefunded = false;

                // إضافة الدفع
                db.Payments.Add(payment);

                // تحديث حالة الدفع
                booking.PaymentStatus = true;

                // حفظ الكل مرة واحدة
                db.SaveChanges();

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return false;
            }
        }

    }
}
