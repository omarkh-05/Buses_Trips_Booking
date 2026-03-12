using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class BooksDTO
    {
        public int BookingID { get; set; }
        public string TripName { get; set; } // جديد
        public DateTime TravelDate { get; set; }
        public string Class { get; set; }
        public byte PassengerCount { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public string TravelType { get; set; }
        public bool PaymentStatus { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
