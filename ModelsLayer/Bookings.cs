using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Bookings
    {
        [Key]
        public int BookingID { get; set; }

        public DateTime TravelDate { get; set; }

        [Required, MaxLength(50)]
        public string Class { get; set; }

        public byte AdultCount { get; set; }
        public byte ChildCount { get; set; }
        public byte DisabledCount { get; set; }

        [NotMapped]
        public byte PassengerCount { get; set; }

        public string PhoneNumber { get; set; }


        [Required, MaxLength(20)]
        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public string TravelType { get; set; }

        public bool PaymentStatus { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal TotalAmount { get; set; }

        public bool IsCounted { get; set; } = false;

        [ForeignKey(nameof(Customer))]
        public int? CustomerID { get; set; }

        [ForeignKey(nameof(Trip))]
        public int TripID { get; set; }

        [ForeignKey(nameof(CreatedByUser))]
        public short? CreatedBy { get; set; }


        // Navigation
        public virtual Customers? Customer { get; set; }
        public virtual Trips? Trip { get; set; }
        public virtual Users? CreatedByUser { get; set; }
        public virtual ICollection<Tickets>? Ticket { get; set; }
        public virtual Payments? Payment { get; set; }
    }
}
