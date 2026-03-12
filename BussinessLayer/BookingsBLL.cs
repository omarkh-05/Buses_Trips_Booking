using DataLayer;
using Microsoft.EntityFrameworkCore;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace BussinessLayer
{
     public interface IBookingsBLL
    {
     //   bool Add();
     //   bool Update();
     //   bool Delete(int bookingID);
     //   Task<List<int>?> GetBookingAllID();
     //   Task<List<BooksDTO>> GetBooksDTOs(int CustomerID);
     //   Task<List<Trip_IDName>> GetInterNationalTripsName();
     //   Task<List<Trip_IDName>> GetNationalTripsName();
     //   Task<int> GetTripIDByName(string tripName);
     //   Task<bool> CheackTripClassAndBookCLass(string tripName, string bookClass);
     //   Task<decimal> CalculateTotalAmount(string TripName, decimal adultCount, decimal childCount, decimal disabledCount);
     //   Task<Bookings?> GetBookingByID(int bookingID);
     //   Task<bool> SaveTicketsAsync(int bookingId, int tripId, List<Tickets> tickets);
       Task<bool> SaveCompleteAsync(Bookings bookings, List<Tickets> tickets, Payments payment);
       Task<decimal> CalculateTotalAmount(string TripName, decimal adultCount, decimal childCount, decimal disabledCount);
        Task<List<BooksDTO>> GetAllBooksDTOForCustomer(int CustomerID);
        Task<bool> IsBookingOwnedByCustomer(int bookingId, int customerId);
        Task<(bool Success, string? ErrorMessage)> UpdateCustomerStats(Customers customer);
    }

    public class BookingsBLL : IBookingsBLL
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

        public async Task<List<BooksDTO>> GetAllBooksDTOForCustomer(int CustomerID) => await BookingsDLL.GetAllBooksDTOForCustomer(CustomerID);

        public static async Task<List<Trip_IDName>> GetInterNationalTripsName() => await TripBLL.GetInterNationalTripsName();

        public static async Task<List<Trip_IDName>> GetNationalTripsName()      =>   await TripBLL.GetNationalTripsName();

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

        public async Task<decimal> CalculateTotalAmount(string TripName , decimal adultCount, decimal childCount, decimal disabledCount)
        {

            TripBLL tripBLL = new TripBLL();
            var trip = await tripBLL.GetTripByName(TripName);
            if(trip == null)
            {
                throw new ArgumentException($"Trip with name '{TripName}' not found");
            }
            decimal ChildPrice = trip.Price * 0.5M;
            decimal PersonPrice = trip.Price;
            decimal TotalAmount = (adultCount * PersonPrice) + (childCount * ChildPrice) + (disabledCount * PersonPrice);

            return TotalAmount;
        }

        // Get booking by ID
        public static Task<Bookings?> GetBookingByID(int bookingID) => BookingsDLL.GetBookingByID(bookingID);
        public static async Task<List<Bookings>?> GetBookingByCustomerID(int customerId) => await BookingsDLL.GetBookingByCustomerID(customerId);


        public async Task<bool> IsBookingOwnedByCustomer(int bookingId, int customerId)
        {
            return await BookingsDLL.IsBookingOwnedByCustomer(bookingId, customerId);
        }

        public async Task<(bool Success, string? ErrorMessage)> UpdateCustomerStats(Customers customer)
        {
            try
            {
                var bookings = await GetBookingByCustomerID(customer.CustomerID);
                bool anyBookingUpdated = false;

                foreach (var booking in bookings)
                {
                    if (booking.Status == "Done" && booking.IsCounted == false)
                    {
                        customer.MoneySpent += booking.TotalAmount;
                        if (booking.Trip?.Route != null)
                            customer.DistanceKm += booking.Trip.Route.DistanceKM;
                        if (booking.TravelType != "National")
                            customer.NumberOfCountryVisited += 1;

                        booking.IsCounted = true;

                        if (!BookingsDLL.Update(booking))
                            return (false, $"Failed to update booking {booking.BookingID}");

                        anyBookingUpdated = true;
                    }
                }

                if (!CustomersDLL.Update(customer))
                    return (false, "Failed to update customer");

                // إذا لم يحدث أي شيء، هذا ليس خطأ، اعتبره نجاح
                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }


        public async Task<bool> SaveTicketsAsync(int bookingId, int tripId, List<Tickets> tickets)
        {
            return await TicketsBLL.SaveTicketsAsync(bookingId, tripId, tickets);
        }


        public async Task<bool> SaveCompleteAsync(Bookings bookings ,List<Tickets> tickets, Payments payment)
        {
            return await BookingsDLL.SaveBookingWithTicketsAndPaymentAsync(bookings, tickets, payment);
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
