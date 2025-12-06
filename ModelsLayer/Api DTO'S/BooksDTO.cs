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

        public DateTime TravelDate { get; set; }

        public string Class { get; set; }

        public byte AdultCount { get; set; }
        public byte ChildCount { get; set; }
        public byte DisabledCount { get; set; }

        public string PhoneNumber { get; set; }

        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public string TravelType { get; set; }

        public bool PaymentStatus { get; set; }

        public decimal TotalAmount { get; set; }


        public int? CustomerID { get; set; }

        public int TripID { get; set; }

        public short? CreatedBy { get; set; }
    }
}
