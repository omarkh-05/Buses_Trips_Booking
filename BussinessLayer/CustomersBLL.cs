using DataLayer;
using ModelsLayer;
using System.Data;
using BussinessLayer.Helper;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public interface ICustomersBLL
    {
        Customers CurrentCustomer { get; set; }
        bool Add();
        bool Register(Customers customer);
        bool Update();
        Task<bool> UpdateProfileWithImage(Customers customer, IFormFile? imageFile);
        bool UpdateRefreshToken(Customers customers);
        bool Delete(int customerID);
        Task<DataTable> GetAllCustomers();
        Task<Customers?> GetCustomerByID(int customerID);
        Task<Customers?> GetGetCustomerByPhoneNumber(string phoneNumber);
        Customers? GetCustomerForLogin(string phoneNumber, string password);
        bool Save();
    }
    public class CustomersBLL : ICustomersBLL
    {
        private enum enMode { AddMode = 1, UpdateMode = 2 };
        private enMode _mode = enMode.AddMode;

        private Customers _customer;

        public CustomersBLL()
        {
            _customer = new Customers();
            _mode = enMode.AddMode;
        }

        public CustomersBLL(Customers customer)
        {
            _customer = customer;
            _mode = enMode.UpdateMode;
        }

        public Customers CurrentCustomer
        {
            get => _customer;
            set => _customer = value;
        }

        // ADD
        public bool Add()
        {
            _customer.CustomerID = CustomersDLL.Add(_customer);
            return _customer.CustomerID > 0;
        }
        public bool Register(Customers customer)
        {
            customer.CustomerID = CustomersDLL.Add(customer);
            return customer.CustomerID > 0;
        }
        // UPDATE
        public bool Update()
        {
            return CustomersDLL.Update(_customer);
        }

        public async Task<bool> UpdateProfileWithImage(Customers customer, IFormFile? imageFile)
        {
            if (imageFile != null)
            {
                try
                {
                    var imagePath = await ImageHelper.SaveImageAsync(imageFile, "images/customers");
                    customer.ImgUrl = imagePath;
                }
                catch (Exception ex)
                {
                    // هنا يمكن تسجيل خطأ الصورة أو رمي استثناء حسب الحاجة
                    return false;
                }
            }

            return CustomersDLL.Update(customer); // تستخدم الدالة الموجودة لديك
        }

        public bool UpdateRefreshToken(Customers customers)
        {
            return CustomersDLL.Update(customers);
        }

        // DELETE
        public bool Delete(int customerID)
        {
            return CustomersDLL.Delete(customerID);
        }

        // GET ALL
        public Task<DataTable> GetAllCustomers()
        {
            return CustomersDLL.GetAllCustomers();
        }

        // GET BY ID
        public Task<Customers?> GetCustomerByID(int customerID)
        {
            return CustomersDLL.GetCustomerByID(customerID);
        }

        // GET BY Phone Number
        public Task<Customers?> GetGetCustomerByPhoneNumber(string phoneNumber)
        {
            return CustomersDLL.GetCustomerByPhoneNumber(phoneNumber);
        }

        // LOGIN
        public Customers? GetCustomerForLogin(string phoneNumber, string password)
        {
            return CustomersDLL.GetCustomerForLogin(phoneNumber, password);
        }

        // SAVE
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
