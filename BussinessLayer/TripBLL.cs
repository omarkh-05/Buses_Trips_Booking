using DataLayer;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class TripBLL
    {
        private enum enMode { AddMode = 1, UpdateMode = 2 }
        private enMode _mode = enMode.AddMode;

        private Trips _trip;

        // Constructor for adding a new trip
        public TripBLL()
        {
            _trip = new Trips();
            _mode = enMode.AddMode;
        }

        // Constructor for updating a trip
        public TripBLL(Trips trip)
        {
            _trip = trip;
            _mode = enMode.UpdateMode;
        }

        // Current Trip object
        public Trips CurrentTrip
        {
            get => _trip;
            set => _trip = value;
        }

        // Add new trip
        public bool Add() => TripDLL.Add(_trip) > 0;

        // Update trip
        public bool Update() => TripDLL.Update(_trip);

        // Delete trip by ID
        public bool Delete(int tripID) => TripDLL.Delete(tripID);

        // Get trip IDs
        public static Task<List<int>?> GetTripAllID() => TripDLL.GetTripAllID();

        // Get all trips as DataTable
        public static Task<DataTable> GetAllTrips() => TripDLL.GetAllTrips();


        public static Task<List<Trip_IDName>> GetInterNationalTripsName() => TripDLL.GetInterNationalTripsName();
        public static Task<List<Trip_IDName>> GetNationalTripsName() => TripDLL.GetNationalTripsName();


        public static List<TripDTO> GetTripDTOs() => TripDLL.GetAllDTOTrips();
        public static async Task<TripDTO> GetTripDTOByName(string TripName) => await TripDLL.GetTripDTOByName(TripName);


        // Get trip by ID
        public static Task<Trips?> GetTripByID(int tripID) => TripDLL.GetTripByID(tripID);

        public static Task<int> GetTripIDByName(string tripName) => TripDLL.GetTripIDByName(tripName);

        // Get trip by ID
        public Task<Trips?> GetTripByName(string tripName) => TripDLL.GetTripByName(tripName);

        public short GetRouteIdByName(string routeName)
        {
          return  RouteBLL.GetRouteIDByName(routeName);
        }

        public async Task<decimal> GetRoutePriceByRoutID(short RouteID)
        {
            RouteBLL routeBLL = new RouteBLL();

            return await routeBLL.GetRoutePriceByID(RouteID);
        }

        public Buses? GetBusIdByName(string BusNumber)
        {
            return BusesBLL.GetBusByNumber(BusNumber);
        }

        // Save trip depending on mode
        public bool Save() => _mode switch
        {
            enMode.AddMode => Add(),
            enMode.UpdateMode => Update(),
            _ => false
        };
    }
}
