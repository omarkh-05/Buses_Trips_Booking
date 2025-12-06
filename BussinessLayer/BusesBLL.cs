using DataLayer;
using ModelsLayer;
using System.Data;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BusesBLL
    {
        private enum enMode { AddMode = 1, UpdateMode = 2 }
        private enMode _mode = enMode.AddMode;

        private Buses _bus;

        public BusesBLL()
        {
            _bus = new Buses();
            _mode = enMode.AddMode;
        }

        public BusesBLL(Buses bus)
        {
            _bus = bus;
            _mode = enMode.UpdateMode;
        }

        public Buses CurrentBus { get => _bus; set => _bus = value; }

        // ================= ADD =================
        public bool Add() => BusesDLL.Add(_bus) > 0;

        // ================= UPDATE =================
        public bool Update() => BusesDLL.Update(_bus);

        // ================= DELETE =================
        public bool Delete(short busID) => BusesDLL.Delete(busID);

        // ================= GET ALL =================
        public static Task<DataTable> GetAllBuses() => BusesDLL.GetAllBuses();

        public static Task<List<string>> GetBusName() => BusesDLL.GetBusName();

        public static Buses? GetBusByNumber(string busNumber) =>  BusesDLL.GetBusByNumber(busNumber);

        // ================= GET BY ID =================
        public Task<Buses?> GetBusByID(short busID) => BusesDLL.GetBusByID(busID);

        // ================= SAVE (Add or Update) =================
        public bool Save() => _mode switch
        {
            enMode.AddMode => Add(),
            enMode.UpdateMode => Update(),
            _ => false
        };
    }
}
