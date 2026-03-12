using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Trip_IDName
    {
        public int tripId { get; set; }
        public string tripName { get; set; }
        public byte availableSeats { get; set; }
        public short tripTimesId { get; set; }
    }
}

