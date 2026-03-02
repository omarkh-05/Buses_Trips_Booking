using Microsoft.EntityFrameworkCore;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CustomersDLL
    {
        // ADD
        public static int Add(Customers customer)
        {
            try
            {
                using var db = new AppDbContext();

                db.Customers.Add(customer);
                db.SaveChanges();

                return customer.CustomerID;
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                if (ex.InnerException != null)
                    errorMessage += "\nInner Exception: " + ex.InnerException.Message;

                EventLog.WriteEntry("Application", "Add Customer From DataLayer Error: " + errorMessage, EventLogEntryType.Error);
                return 0;
            }
        }

        // UPDATE
        public static bool Update(Customers customer)
        {
            try
            {
                using var db = new AppDbContext();

                var oldCustomer = db.Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
                if (oldCustomer == null)
                    return false;

                db.Entry(oldCustomer).CurrentValues.SetValues(customer);

                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                if (ex.InnerException != null)
                    errorMessage += "\nInner Exception: " + ex.InnerException.Message;

                EventLog.WriteEntry("Application", "Update Customer Error: " + errorMessage, EventLogEntryType.Error);
                return false;
            }
        }

        // DELETE (Soft Delete)
        public static bool Delete(int customerId)
        {
            try
            {
                using var db = new AppDbContext();

                var customer = db.Customers.FirstOrDefault(c => c.CustomerID == customerId);

                if (customer == null)
                    return false;

                customer.IsActive = false;

                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                if (ex.InnerException != null)
                    errorMessage += "\nInner Exception: " + ex.InnerException.Message;

                EventLog.WriteEntry("Application", "Delete Customer Error: " + errorMessage, EventLogEntryType.Error);
                return false;
            }
        }

        // GET ALL AS DATATABLE
        public static async Task<DataTable> GetAllCustomers()
        {
            try
            {
                using var db = new AppDbContext();

                var list = await db.Customers
                                   .Include(c => c.CustomerCountry)
                                   .ToListAsync();

                DataTable dt = new DataTable();
                dt.Columns.Add("CustomerID", typeof(int));
                dt.Columns.Add("FullName", typeof(string));
                dt.Columns.Add("PhoneNumber", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("CountryId", typeof(short));
                dt.Columns.Add("CountryName", typeof(string));
                dt.Columns.Add("DateOfBirth", typeof(DateTime));
                dt.Columns.Add("Password", typeof(string));
                dt.Columns.Add("IsActive", typeof(bool));

                foreach (var c in list)
                {
                    dt.Rows.Add(
                        c.CustomerID,
                        c.FullName,
                        c.PhoneNumber,
                        c.Email,
                        c.CountryId,
                        c.CustomerCountry?.CountryName,
                        c.DateOfBirth,
                        c.Password,
                        c.IsActive
                    );
                }

                return dt;
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                if (ex.InnerException != null)
                    errorMessage += "\nInner Exception: " + ex.InnerException.Message;

                EventLog.WriteEntry("Application", "GetAllCustomers Error: " + errorMessage, EventLogEntryType.Error);

                return new DataTable();
            }
        }

        // GET BY ID
        public static async Task<Customers?> GetCustomerByID(int customerId)
        {
            try
            {
                using var db = new AppDbContext();

                return await db.Customers
                               .Include(c => c.CustomerCountry)
                               .FirstOrDefaultAsync(c => c.CustomerID == customerId);
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                if (ex.InnerException != null)
                    errorMessage += "\nInner Exception: " + ex.InnerException.Message;

                EventLog.WriteEntry("Application", "GetCustomerByID Error: " + errorMessage, EventLogEntryType.Error);

                return null;
            }
        }

        // GET BY Phone Number
        public static async Task<Customers?> GetCustomerByPhoneNumber(string phoneNumber)
        {
            try
            {
                using var db = new AppDbContext();

                return await db.Customers
                               .Include(c => c.CustomerCountry)
                               .FirstOrDefaultAsync(c => c.PhoneNumber == phoneNumber);
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                if (ex.InnerException != null)
                    errorMessage += "\nInner Exception: " + ex.InnerException.Message;

                EventLog.WriteEntry("Application", "GetCustomerByPhoneNumber Error: " + errorMessage, EventLogEntryType.Error);

                return null;
            }
        }

        // LOGIN
        public static Customers? GetCustomerForLogin(string phoneNumber, string hashedPassword)
        {
            try
            {
                using var db = new AppDbContext();

                return db.Customers.FirstOrDefault(c => c.PhoneNumber == phoneNumber && c.Password == hashedPassword && c.IsActive);
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                if (ex.InnerException != null)
                    errorMessage += "\nInner Exception: " + ex.InnerException.Message;

                EventLog.WriteEntry("Application", "Customer Login Error: " + errorMessage, EventLogEntryType.Error);

                return null;
            }
        }

    }
}
