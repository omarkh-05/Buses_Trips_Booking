using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    [Table("Drivers")]
    public class Drivers
    {
        [Key]
        public short DriverID { get; set; }

        [Required, MaxLength(100)]
        public string DriverName { get; set; }

        [MaxLength(50)]
        public string? DriverRank { get; set; }

        [ForeignKey(nameof(CreatedByUser))]
        public short CreatedByUserID { get; set; }

        // Navigation
        public virtual Users CreatedByUser { get; set; }
        public virtual ICollection<Buses>? Bus { get; set; }
    }
}
