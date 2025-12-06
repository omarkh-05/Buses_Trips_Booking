using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class CustomersCountries
    {
        [Key]
        public short CountryID { get; set; }

        [MaxLength(50)]
        public string CountryName { get; set; }

        // Navigation to Customers
        public virtual ICollection<Customers>? Customers { get; set; }
    }

}
