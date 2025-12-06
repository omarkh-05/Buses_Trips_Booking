using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Countries
    {
        [Key]
        public short CountryID { get; set; }

        [Required, MaxLength(100)]
        public string CountryName { get; set; }


        // Navigation
        // the ? mean maybe the Routes collection Still empty and to be safe from object reference null
        public virtual ICollection<Cities> Cities { get; set; } = new List<Cities>();
        public virtual ICollection<Routes>? RoutesFrom { get; set; }
        public virtual ICollection<Routes>? RoutesTo { get; set; }
    }
}
