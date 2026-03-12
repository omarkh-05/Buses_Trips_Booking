using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class CalculateTotalTripAmount
    {
        public string tripName { get; set; }
        public decimal adultCount { get; set; }
        public decimal childCount { get; set; }
        public decimal disabledCount { get; set; }
    }
}
