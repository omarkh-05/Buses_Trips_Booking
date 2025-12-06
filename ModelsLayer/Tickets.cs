using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Tickets
    {
        [Key]
        public int TicketID { get; set; }

        [ MaxLength(100)]
        public string PassengerName { get; set; }

        [ MaxLength(10)]
        public string PassengerGender { get; set; }

        [MaxLength(20)]
        public string NationalID { get; set; }

        public DateTime IssueDate { get; set; }

        public byte SeatNumber { get; set; }

        [Required, MaxLength(100)]
        public string QRCode { get; set; }
            
        [MaxLength(20)]
        public string PersonType { get; set; }

        [ForeignKey(nameof(Booking))]
        public int BookingID { get; set; }

        // Navigation
        public virtual Bookings? Booking { get; set; }
    }
}
