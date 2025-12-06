using DataLayer;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace BussinessLayer
{
    public class RouteBLL
    {
        private enum enMode { AddMode = 1, UpdateMode = 2 }
        private enMode _mode = enMode.AddMode;

        private Routes _route;

        // Constructor for adding a new route
        public RouteBLL()
        {
            _route = new Routes();
            _mode = enMode.AddMode;
        }

        // Constructor for updating an existing route
        public RouteBLL(Routes route)
        {
            _route = route;
            _mode = enMode.UpdateMode;
        }

        // Current route object
        public Routes CurrentRoute { get => _route; set => _route = value; }

        // Add a new route
        public bool Add() => RouteDLL.Add(_route) > 0;

        // Get all route IDs
        public static async Task<List<short>?> GetRouteAllID()
        {
            return await RouteDLL.GetRouteAllID();
        }

        // Update an existing route
        public bool Update() => RouteDLL.Update(_route);

        // Delete a route by ID
        public bool Delete(short routeId) => RouteDLL.Delete(routeId);

        // Get all routes as a DataTable
        public static Task<DataTable> GetAllRoutes() => RouteDLL.GetAllRoutes();

        public static Task<List<string>> GetRoutesNames() => RouteDLL.GetAllRoutesNames();

        public static short GetRouteIDByName(string routeName) => RouteDLL.GetRouteIDByName(routeName);

       public async Task<decimal> GetRoutePriceByID(short routeId)
        {
            return await RouteDLL.GetRoutePriceByID(routeId);
        }

        public static async Task<string> GetCountryNameByID(short? id)
        {
           return await CountriesBLL.GetCountryNameByCountryIDAsync(id);
        }

        public static async Task<string> GetCityNameByID(short id)
        {
            return await CitiesBLL.GetCityNameByCityIDAsync(id);
        }

        // Get a specific route by its ID
        public Task<Routes?> GetRouteByID(short routeId) => RouteDLL.GetRouteByID(routeId);

        // Save the route based on mode (add or update)
        public bool Save() => _mode switch
        {
            enMode.AddMode => Add(),
            enMode.UpdateMode => Update(),
            _ => false
        };
    }
}
