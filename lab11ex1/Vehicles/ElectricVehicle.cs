using lab11ex1.Vehicles.Interfaces;
using lab11ex1.FuelType;

namespace lab11ex1.Vehicles
{
    class ElectricVehicle : Vehicle, IElectric
    {
        public ElectricVehicle(string name) : base(name, Fuel.Electric)
        {

        }
    }
}
