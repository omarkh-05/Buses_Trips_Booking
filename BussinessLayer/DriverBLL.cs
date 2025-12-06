using DataLayer;
using ModelsLayer;
using System.Data;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class DriversBLL
    {
        private enum enMode { AddMode = 1, UpdateMode = 2 }
        private enMode _mode = enMode.AddMode;

        private Drivers _driver;

        public DriversBLL()
        {
            _driver = new Drivers();
            _mode = enMode.AddMode;
        }

        public DriversBLL(Drivers driver)
        {
            _driver = driver;
            _mode = enMode.UpdateMode;
        }

        public Drivers CurrentDriver { get => _driver; set => _driver = value; }

        public bool Add() => DriversDLL.Add(_driver) > 0;

        public static async Task<List<short>?> GetDriverAllID()
        {
            return await DriversDLL.GetDriverAllID();
        }

        public bool Update() => DriversDLL.Update(_driver);

        public bool Delete(short driverId) => DriversDLL.Delete(driverId);

        public static Task<DataTable> GetAllDrivers() => DriversDLL.GetAllDrivers();

        public Task<Drivers?> GetDriverByID(short driverId) => DriversDLL.GetDriverByID(driverId);

        public bool Save() => _mode switch
        {
            enMode.AddMode => Add(),
            enMode.UpdateMode => Update(),
            _ => false
        };
    }
}
