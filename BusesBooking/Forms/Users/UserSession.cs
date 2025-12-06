using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBusesBooking.Forms.Users
{
    public class UserSession
    {
        public static short UserID { get; private set; }
        public static string Role { get; private set; }
        public static string UserName { get; private set; }
        public static string Image { get; private set; }
        public static bool IsActive { get; private set; }

        public static void SetUser(ModelsLayer.Users user)
        {
            UserID = user.UserID;
            Role = user.Role;
            UserName = user.UserName;
            IsActive = user.IsActive;
            Image = user.ImgPath;
        }

        public static void Clear()
        {
            UserID = 0;
            Role = null;
            UserName = null;
            IsActive = false;
            Image = null;
        }

        public static bool RememberUsernameAndPassword(string username, string password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\Buses_Booking_System";
            string valueName = "CurrentUserInBusesBookingSystem";
            string valueData = $"{username}#{password}";

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

        public static bool GetStoredCredential(ref string username, ref string password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\Buses_Booking_System";
            string valueName = "CurrentUserInBusesBookingSystem";

            try
            {
                object value = Registry.GetValue(keyPath, valueName, null);
                if (value != null)
                {
                    string[] currentuser = value.ToString().Split('#');
                    if (currentuser.Length == 2)
                    {
                        username = currentuser[0];
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
