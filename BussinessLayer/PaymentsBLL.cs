using DataLayer;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class PaymentsBLL
    {
        public Payments CurrentPayment { get; set; }

        public PaymentsBLL() { }

        public PaymentsBLL(Payments payment)
        {
            CurrentPayment = payment;
        }

        //  not Used
        public bool Save()
        {
            return PaymentsDLL.Save(CurrentPayment);
        }

        public static async Task<DataTable> GetAllPayments()
        {
            return await PaymentsDLL.GetAllPayments();
        }

        public Task<Payments?> GetPaymentByID(int paymentID)
        {
            return PaymentsDLL.GetPaymentByID(paymentID);
        }

        public static Task<bool> UpdateRefund(int paymentID)
        {
            return PaymentsDLL.UpdateRefund(paymentID);
        }
    }
}
