using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; }

        [Required, MaxLength(20)]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]

        public string? Email { get; set; }

        [ForeignKey("CustomerCountry")]
        public short CountryId { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required, MaxLength(100)]
        public string Password { get; set; }

        public bool IsActive { get; set; }

        // Navigation
        [JsonIgnore]
        public virtual ICollection<Bookings>? Booking { get; set; }
        [JsonIgnore]
        public virtual CustomersCountries? CustomerCountry { get; set; }

    }
}
