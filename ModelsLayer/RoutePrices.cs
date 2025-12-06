using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsLayer
{
    public class RoutePrices
    {
        [Key]
        public short RoutePriceID { get; set; }

        [Required, MaxLength(50)]
        public string Season { get; set; }

        [Required, MaxLength(50)]
        public string TravelClass { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }

        [ForeignKey(nameof(Route))]
        public short RouteID { get; set; }

        [ForeignKey(nameof(CreatedByUser))]
        public short CreatedByUserID { get; set; }

        // Navigation
        public virtual Routes Route { get; set; }
        public virtual Users CreatedByUser { get; set; }
    }
}
