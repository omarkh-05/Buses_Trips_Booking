using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class CompleteBookingDTO
    {
        public Bookings Booking { get; set; }
        public List<Tickets> Tickets { get; set; }
        public Payments Payments { get; set; }
    }
}
