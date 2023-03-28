using lab11ex1.FuelType;
using lab11ex1.Vehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab11ex1.Vehicles
{
    abstract class Vehicle: IFuel
    {
        private readonly Guid id = Guid.NewGuid();
        private Fuel fuel;
        protected Vehicle(string name, Fuel fuel)
        {
            this.Name = name;
            this.fuel = fuel;
        }
        public string Name{ get; private set; }
        public void Fill(int qty)
        {
            Console.WriteLine($"Filled the vehicle {Name}, id {id} with {qty} {fuel}");
        }

        public override string ToString()
        {
            return $"Filled the vehicle {Name}, id {id} with {fuel}";
        }
    }
}
