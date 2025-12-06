using Microsoft.EntityFrameworkCore;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RouteDLL
    {
        // ========== ADD ROUTE ==========
        public static short Add(Routes route)
        {
            try
            {
                using var db = new AppDbContext();
                db.Routes.Add(route);
                db.SaveChanges();
                return route.RouteID;
            }
            catch (Exception ex)
            {
                WriteEventLog("Add Route Error", ex);
                return 0;
            }
        }

        // ========== UPDATE ROUTE ==========
        public static bool Update(Routes route)
        {
            try
            {
                using var db = new AppDbContext();
                var existing = db.Routes.FirstOrDefault(r => r.RouteID == route.RouteID);
                if (existing == null) return false;

                db.Entry(existing).CurrentValues.SetValues(route);
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                WriteEventLog("Update Route Error", ex);
                return false;
            }
        }

        // ========== DELETE ROUTE ==========
        public static bool Delete(short routeId)
        {
            try
            {
                using var db = new AppDbContext();
                var existing = db.Routes.FirstOrDefault(r => r.RouteID == routeId);
                if (existing == null) return false;

                db.Routes.Remove(existing);
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                WriteEventLog("Delete Route Error", ex);
                return false;
            }
        }

        // ========== GET ALL ROUTES ==========
        public static async Task<DataTable> GetAllRoutes()
        {
            try
            {
                using var db = new AppDbContext();
                var list = await db.Routes
                                   .Include(r => r.FromCountry)
                                   .Include(r => r.ToCountry)
                                   .Include(r => r.FromCity)
                                   .Include(r => r.ToCity)
                                   .Include(r => r.CreatedByUser)
                                   .ToListAsync();

                DataTable dt = new DataTable();
                dt.Columns.Add("RouteID", typeof(short));
                dt.Columns.Add("DistanceKM", typeof(double));
                dt.Columns.Add("Price", typeof(decimal));
                dt.Columns.Add("IsInternational", typeof(bool));
                dt.Columns.Add("FromCountry", typeof(string));
                dt.Columns.Add("ToCountry", typeof(string));
                dt.Columns.Add("FromCity", typeof(string));
                dt.Columns.Add("ToCity", typeof(string));
                dt.Columns.Add("RouteName", typeof(string));
                dt.Columns.Add("CreatedByUser", typeof(string));

                foreach (var r in list)
                {
                    dt.Rows.Add(r.RouteID, r.DistanceKM, r.Price, r.IsInternational,
                                r.FromCountry?.CountryName, r.ToCountry?.CountryName,
                                r.FromCity?.CityName, r.ToCity?.CityName,
                                r.RouteName, r.CreatedByUser?.UserName);
                }

                return dt;
            }
            catch (Exception ex)
            {
                WriteEventLog("GetAllRoutes Error", ex);
                return new DataTable();
            }
        }

        // ========== GET ALL ROUTE IDs ==========
        public static async Task<List<short>> GetRouteAllID()
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Routes.Select(r => r.RouteID).ToListAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("GetRouteAllID Error", ex);
                return new List<short>();
            }
        }

        // ========== GET ROUTE BY ID ==========
        public static async Task<Routes?> GetRouteByID(short routeId)
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Routes
                               .Include(r => r.FromCountry)
                               .Include(r => r.ToCountry)
                               .Include(r => r.FromCity)
                               .Include(r => r.ToCity)
                               .Include(r => r.CreatedByUser)
                               .FirstOrDefaultAsync(r => r.RouteID == routeId);
            }
            catch (Exception ex)
            {
                WriteEventLog("GetRouteByID Error", ex);
                return null;
            }
        }

        public static async Task<decimal> GetRoutePriceByID(short routeId)
        {
            try
            {
                using var db = new AppDbContext();
                var price = await db.Routes
                                    .Where(r => r.RouteID == routeId)
                                    .Select(r => r.RoutePrice)
                                    .FirstOrDefaultAsync();
                return Convert.ToDecimal(price);
            }
            catch (Exception ex)
            {
                WriteEventLog("GetRoutePriceByID Error", ex);
                return 0;
            }
        }

        // ========== GET ALL ROUTE NAMES ==========
        public static async Task<List<string>> GetAllRoutesNames()
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Routes.Select(r => r.RouteName).ToListAsync();
            }
            catch (Exception ex)
            {
                WriteEventLog("GetAllRoutesNames Error", ex);
                return new List<string>();
            }
        }

        // ========== GET ROUTE ID BY NAME ==========
        public static short GetRouteIDByName(string routeName)
        {
            try
            {
                using var db = new AppDbContext();
                return db.Routes.FirstOrDefault(r => r.RouteName == routeName)?.RouteID ?? 0;
            }
            catch (Exception ex)
            {
                WriteEventLog("GetRouteIDByName Error", ex);
                return 0;
            }
        }

        // ===================== EventLog Helper =====================
        private static void WriteEventLog(string title, Exception ex)
        {
            string error = ex.Message;
            if (ex.InnerException != null)
                error += "\nInner Exception: " + ex.InnerException.Message;

            EventLog.WriteEntry("Application", $"{title}: {error}", EventLogEntryType.Error);
        }
    }
}
