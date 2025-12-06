using Microsoft.Win32;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBusesBooking.Forms.Customer.Classes
{
    public class CustomerSession
    {
        public static int CustomerID { get; private set; }
        public static string FullName { get; private set; }
        public static string PhoneNumber { get; private set; }
        public static bool IsActive { get; set; }

        public static void SetCustomer(CustomerDTOForLogin customers)
        {
            CustomerID = customers.CustomerID;
            FullName = customers.FullName;
            IsActive = customers.IsActive;
            PhoneNumber = customers.PhoneNumber;
        }

        public static void Clear()
        {
            CustomerID = 0;
            FullName = null;
            PhoneNumber = null;
            IsActive = false;
        }

        public static bool RememberFullameAndPassword(string PhoneNumber, string password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\Buses_Booking_System";
            string valueName = "CurrentCustomer";
            string valueData = $"{PhoneNumber}#{password}";

            try
            {
                Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);
                return true;
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Application", $"RememberUsernameAndPassword {ex.Message}", EventLogEntryType.Error);
                return false;
            }
        }

        public static bool GetStoredCredential(ref string PhoneNumber, ref string password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\Buses_Booking_System";
            string valueName = "CurrentCustomer";

            try
            {
                object value = Registry.GetValue(keyPath, valueName, null);
                if (value != null)
                {
                    string[] currentuser = value.ToString().Split('#');
                    if (currentuser.Length == 2)
                    {
                        PhoneNumber = currentuser[0];
                        password = currentuser[1];
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Application", $"GetStoredCredential {ex.Message}", EventLogEntryType.Error);
                return false;
            }
        }
    }
}
