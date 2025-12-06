using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Buses
    {
        [Key]
        public short BusID { get; set; }

        [Required, MaxLength(50)]
        public string BusNumber { get; set; }
        [MaxLength(50)]
        public string? BusModel { get; set; }
        [Required, MaxLength(20)]
        public string PlateNumber { get; set; }

        public byte Capacity { get; set; }
        public string Class { get; set; }
        public string Category { get; set; }

        [Required, MaxLength(20)]
        public string Status { get; set; }

        public DateTime YearOfMananufacture { get; set; }

        [ForeignKey(nameof(Driver))]
        public short DriverID { get; set; }

        [ForeignKey(nameof(CreatedByUser))]
        public short CreatedByUserID { get; set; }


        // Navigation
        public virtual Drivers Driver { get; set; }
        public virtual Users CreatedByUser { get; set; }
        public virtual ICollection<Trips>? Trip { get; set; }
    }
}
