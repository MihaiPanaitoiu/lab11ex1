using lab11ex1.Vehicles.Interfaces;
using lab11ex1.FuelType;

namespace lab11ex1.Vehicles
{
    class LPGVehicle : Vehicle, ILPG
    {
        public LPGVehicle(string name) : base(name, Fuel.LPG)
        {

        }
    }
}
