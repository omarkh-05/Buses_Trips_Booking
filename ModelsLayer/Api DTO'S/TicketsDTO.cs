using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer.Api_DTO_S
{
    public class TicketsDTO
    {
        public int TicketID { get; set; }
        public string PassengerName { get; set; }
        public string PassengerGender { get; set; }
        public string NationalID { get; set; }
        public DateTime IssueDate { get; set; }
        public byte SeatNumber { get; set; }
        public string QRCode { get; set; }
        public string PersonType { get; set; }
        public int BookingID { get; set; }
    }
}
