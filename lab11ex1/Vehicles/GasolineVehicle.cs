using lab11ex1.Vehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using lab11ex1.FuelType;

namespace lab11ex1.Vehicles
{
    class GasolineVehicle : Vehicle, IGasoline
    {
        public GasolineVehicle(string name): base(name, Fuel.Gasoline)
        {

        }
    }
}
