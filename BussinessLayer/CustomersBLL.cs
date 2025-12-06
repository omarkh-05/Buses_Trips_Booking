using DataLayer;
using ModelsLayer;
using System.Data;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class CustomersBLL
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

        // UPDATE
        public bool Update()
        {
            return CustomersDLL.Update(_customer);
        }

        // DELETE
        public bool Delete(int customerID)
        {
            return CustomersDLL.Delete(customerID);
        }

        // GET ALL
        public static Task<DataTable> GetAllCustomers()
        {
            return CustomersDLL.GetAllCustomers();
        }

        // GET BY ID
        public Task<Customers?> GetCustomerByID(int customerID)
        {
            return CustomersDLL.GetCustomerByID(customerID);
        }

        // LOGIN
        public Customers GetCustomerForLogin(string phoneNumber, string password)
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
