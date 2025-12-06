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
    public class UsersDLL
    {
        // ========== ADD USER ==========
        public static byte Add(Users users)
        {
            try
            {
                using var db = new AppDbContext();
                db.Users.Add(users);
                db.SaveChanges();
                return (byte)users.UserID;
            }
            catch (Exception ex)
            {
                WriteEventLog("Add User Error", ex);
                return 0;
            }
        }

        // ========== UPDATE USER ==========
        public static bool Update(Users users)
        {
            try
            {
                using var db = new AppDbContext();
                var existing = db.Users.FirstOrDefault(u => u.UserID == users.UserID);
                if (existing == null) return false;

                db.Entry(existing).CurrentValues.SetValues(users);
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                WriteEventLog("Update User Error", ex);
                return false;
            }
        }

        // ========== DELETE USER (SOFT DELETE) ==========
        public static bool Delete(byte userId)
        {
            try
            {
                using var db = new AppDbContext();
                var existing = db.Users.FirstOrDefault(u => u.UserID == userId);
                if (existing == null) return false;

                existing.IsActive = false;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                WriteEventLog("Delete User Error", ex);
                return false;
            }
        }

        // ========== GET ALL USERS ==========
        public static async Task<DataTable> GetAllUsers()
        {
            try
            {
                using var db = new AppDbContext();
                var list = await db.Users.ToListAsync();

                DataTable dt = new DataTable();
                dt.Columns.Add("UserID", typeof(byte));
                dt.Columns.Add("UserName", typeof(string));
                dt.Columns.Add("Password", typeof(string));
                dt.Columns.Add("Role", typeof(string));
                dt.Columns.Add("IsActive", typeof(bool));
                dt.Columns.Add("ImgPath", typeof(string));

                foreach (var u in list)
                    dt.Rows.Add(u.UserID, u.UserName, u.Password, u.Role, u.IsActive, u.ImgPath);

                return dt;
            }
            catch (Exception ex)
            {
                WriteEventLog("GetAllUsers Error", ex);
                return new DataTable();
            }
        }

        // ========== GET USER BY ID ==========
        public static async Task<Users?> GetUserByID(byte userId)
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Users.FirstOrDefaultAsync(u => u.UserID == userId);
            }
            catch (Exception ex)
            {
                WriteEventLog("GetUserByID Error", ex);
                return null;
            }
        }

        // ========== LOGIN ==========
        public static async Task<Users?> GetUserForLogin(string userName, string password)
        {
            try
            {
                using var db = new AppDbContext();
                return await db.Users
                               .FirstOrDefaultAsync(u =>
                                   u.UserName == userName &&
                                   u.Password == password &&
                                   u.IsActive);
            }
            catch (Exception ex)
            {
                WriteEventLog("GetUserForLogin Error", ex);
                return null;
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
