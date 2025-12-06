using DataLayer;
using ModelsLayer;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace BussinessLayer
{
    public class UsersBLL
    {
        private enum enMode { AddMode = 1, UpdateMode = 2 };
        enMode _mode = enMode.AddMode;

        private Users _user;

        public UsersBLL()
        {
            _user = new Users();
            _mode = enMode.AddMode;
        }

        public UsersBLL(Users user)
        {
            _user = user;
            _mode = enMode.UpdateMode;
        }

        public Users currentuser { get => _user; set => _user = value; }

        public bool Add()
        {
            _user.UserID = UsersDLL.Add(_user);
            return _user.UserID > 0;
        }

        public bool Update()
        {
            return UsersDLL.Update(_user);
        }

        public bool Delete(byte UserID)
        {
            return UsersDLL.Delete(UserID);
        }

        public static Task<DataTable> GetAllUsers()
        {
            return UsersDLL.GetAllUsers();
        }

        public Task<Users?> GetUserByID(byte UserID)
        {
            return UsersDLL.GetUserByID(UserID);
        }

        public static Task<Users?> GetUserForLogin(string UserName, string Password)
        {
            return UsersDLL.GetUserForLogin(UserName, Password);
        }

        public bool Save()
        {
            return _mode switch
            {
                enMode.AddMode => Add(),
                enMode.UpdateMode => Update(),
                _ => false
            };
        }
    }
}
