using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Cities
    {
        [Key]
        public short CityID { get; set; }

        [Required, MaxLength(100)]
        public string CityName { get; set; }

        [ForeignKey(nameof(Country))]
        public short CountryID { get; set; }

        public virtual Countries Country { get; set; }

        public virtual ICollection<Routes> RoutesFrom { get; set; } = new List<Routes>();
        public virtual ICollection<Routes> RoutesTo { get; set; } = new List<Routes>();
    }
}
