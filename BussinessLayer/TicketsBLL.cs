using System.Data;
using System.Threading.Tasks;
using DataLayer;
using ModelsLayer;

namespace BussinessLayer
{
    public class TicketsBLL
    {
        // Get All Tickets (DataTable)
        public static async Task<DataTable> GetAllTickets()
        {
            return await TicketsDLL.GetAllTickets();
        }

        // Get Ticket By ID
        public Task<Tickets?> GetTicketByID(int ticketID)
        {
            return TicketsDLL.GetTicketByID(ticketID);
        }


        public static async Task<bool> SaveTicketsAsync(int bookingId, int tripId, List<Tickets> tickets)
        {
            return await TicketsDLL.SaveTicketsAsync(bookingId, tripId, tickets);
        }

        public static async Task<List<byte>> AllBookedSeats(int tripId) => await TicketsDLL.AllBookedSeats(tripId);
        

    }
}
