using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    [NotMapped]
    public class TripDTO
    {
        public int TripID { get; set; }
        public bool IsInternational { get; set; }
        public DateTime TripDate { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public decimal Price { get; set; }
        public byte AvailableSeats { get; set; }
        public string Status { get; set; }
        public string Route { get; set; }
        public string Bus { get; set; }
        public string TripName { get; set; }
        public string Class { get; set; }
        public string CreatedByUser { get; set; }
    }
}
