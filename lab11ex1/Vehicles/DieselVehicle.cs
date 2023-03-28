using lab11ex1.Vehicles.Interfaces;
using lab11ex1.FuelType;

namespace lab11ex1.Vehicles
{
    class DieselVehicle : Vehicle, IDiesel
    {
        public DieselVehicle(string name) : base(name, Fuel.Diesel)
        {

        }
    }
}
