using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    

    public class Trips
    {
        [Key]
        public int TripID { get; set; }

        [Required]
        public bool IsInternational { get; set; }
        public DateTime TripDate { get; set; }
        public TimeOnly DepartureTime { get; set; }
        public TimeOnly ArrivalTime { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        public byte AvailableSeats { get; set; }

        [MaxLength(70)]
        public string TripName { get; set; }

        [MaxLength(30)]
        public string Class { get; set; }


        [Required, MaxLength(20)]
        public string Status { get; set; }

        [ForeignKey(nameof(Route))]
        public short RouteID { get; set; }

        [ForeignKey(nameof(Bus))]
        public short BusID { get; set; }

        [ForeignKey(nameof(CreatedByUser))]
        public short CreatedByUserID { get; set; }

        
        public short TripTimeID { get; set; }

        // Navigation
        public virtual Routes Route { get; set; }
        public virtual Buses Bus { get; set; }
        public virtual Users CreatedByUser { get; set; }
        public virtual ICollection<Bookings>? Booking { get; set; }
        [ForeignKey(nameof(TripTimeID))]
        public virtual TripTimes TripTimes { get; set; }
    }
}
