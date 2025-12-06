using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsLayer
{
    public class Users
    {
        [Key]
        public short UserID { get; set; }

        [Required, MaxLength(100)]
        public string UserName { get; set; }

        [Required, MaxLength(255)]
        public string Password { get; set; }

        [Required, MaxLength(50)]
        public string Role { get; set; }

        public bool IsActive { get; set; }

        [MaxLength(255)]
        public string? ImgPath { get; set; }

        // Navigation
        public virtual ICollection<Buses>? Bus { get; set; }
        public virtual ICollection<Drivers>? Driver { get; set; }
        public virtual ICollection<Routes>? Rout { get; set; }
        public virtual ICollection<RoutePrices>? RoutPrice { get; set; }
        public virtual ICollection<Trips>? Trip { get; set; }
        public virtual ICollection<Bookings>? Booking { get; set; }
    }
}
