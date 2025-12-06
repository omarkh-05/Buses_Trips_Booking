using DataLayer;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BookingsBLL
    {
        private enum enMode { AddMode = 1, UpdateMode = 2 }
        private enMode _mode = enMode.AddMode;

        private Bookings _booking;
       public int _bookingID = -1;

        // Constructor for adding a new booking
        public BookingsBLL()
        {
            _booking = new Bookings();
            _mode = enMode.AddMode;
        }

        // Constructor for updating a booking
        public BookingsBLL(Bookings booking)
        {
            _booking = booking;
            _mode = enMode.UpdateMode;
        }

        // Current Booking object
        public Bookings CurrentBooking
        {
            get => _booking;
            set => _booking = value;
        }

        // Add new booking
        public bool Add()
        {
            _bookingID = BookingsDLL.Add(_booking);
            return _bookingID > 0;
        }

        // Update booking
        public bool Update() => BookingsDLL.Update(_booking);

        // Delete booking by ID
        public bool Delete(int bookingID) => BookingsDLL.Delete(bookingID);

        // Get all booking IDs
        public static Task<List<int>?> GetBookingAllID() => BookingsDLL.GetBookingAllID();

        // Get all bookings as DataTable
        public static Task<DataTable> GetAllBookings() => BookingsDLL.GetAllBookings();

        public static async Task<List<BooksDTO>> GetBooksDTOs(int CustomerID) => await BookingsDLL.GetAllBooksDTOForCusotmer(CustomerID);

        public static async Task<List<string>> GetInterNationalTripsName() => await TripBLL.GetInterNationalTripsName();

        public static async Task<List<string>> GetNationalTripsName() => await TripBLL.GetNationalTripsName();

        public static async Task<int> GetTripIDByName(string tripName)
        {
            TripBLL trip = new TripBLL();
            var Trip = await trip.GetTripByName(tripName);
            return Trip.TripID;
        }

        public static async Task<bool> CheackTripClassAndBookCLass(string tripName, string bookClass)
        {
            TripBLL tripBLL = new TripBLL();
            var trip = await tripBLL.GetTripByName(tripName);
            if (trip.Class == bookClass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static async Task<decimal> CalculateTotalAmount( string TripName , decimal adultCount, decimal childCount, decimal disabledCount)
        {

            TripBLL tripBLL = new TripBLL();
            var trip = await tripBLL.GetTripByName(TripName);

            decimal ChildPrice = trip.Price * 0.5M;
            decimal PersonPrice = trip.Price;
            decimal TotalAmount = (adultCount * PersonPrice) + (childCount * ChildPrice) + (disabledCount * PersonPrice);

            return TotalAmount;
        }

        // Get booking by ID
        public static Task<Bookings?> GetBookingByID(int bookingID) => BookingsDLL.GetBookingByID(bookingID);


        public async Task<bool> SaveTicketsAsync(int bookingId, int tripId, List<Tickets> tickets)
        {
            return await TicketsBLL.SaveTicketsAsync(bookingId, tripId, tickets);
        }


        public async Task<bool> SaveCompleteAsync(List<Tickets> tickets, Payments payment)
        {
            return await BookingsDLL.SaveBookingWithTicketsAndPaymentAsync(CurrentBooking, tickets, payment);
        }


        // Save booking depending on mode
        public bool Save() => _mode switch
        {
            enMode.AddMode => Add(),
            enMode.UpdateMode => Update(),
            _ => false
        };
    }
}
