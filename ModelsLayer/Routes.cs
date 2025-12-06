using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsLayer
{
    public class Routes
    {
        [Key]
        public short RouteID { get; set; }

        public double DistanceKM { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        [Required]
        public bool IsInternational { get; set; }

        [Required]
        public string RouteName { get; set; }

        [ForeignKey(nameof(FromCountry))]
        public short FromCountryID { get; set; }

        [ForeignKey(nameof(ToCountry))]
        public short? ToCountryID { get; set; }

        [ForeignKey(nameof(FromCity))]
        public short FromCityID { get; set; }

        [ForeignKey(nameof(ToCity))]
        public short ToCityID { get; set; }


        [ForeignKey(nameof(CreatedByUser))]
        public short CreatedByUserID { get; set; }

        // Navigation
        public virtual Countries FromCountry { get; set; }
        public virtual Countries ToCountry { get; set; }
        public virtual Users CreatedByUser { get; set; }
        public virtual Cities FromCity { get; set; }
        public virtual Cities ToCity { get; set; }

        public virtual ICollection<RoutePrices> RoutePrice { get; set; } = new List<RoutePrices>();
        public virtual ICollection<Trips> Trip { get; set; } = new List<Trips>();
    }
}
