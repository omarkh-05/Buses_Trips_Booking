using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Payments
    {
        [Key]
        public int PaymentID { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Amount { get; set; }

        [Required, MaxLength(50)]
        public string PaymentMethod { get; set; }

        public DateTime TransactionDate { get; set; }

        public bool IsRefunded { get; set; }

        [ForeignKey(nameof(Booking))]
        public int BookingID { get; set; }

        // Navigation
        public virtual Bookings? Booking { get; set; }
    }
}
