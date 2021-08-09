using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Your_Garage.Vehicle;

namespace Your_Garage
{
    abstract class Watercraft : VehicleBase
    {
        public string Name { get; set; }

        public Watercraft(string name)
        {
            Name = $"The Royal {name}";
            FuelCapacity = 80;
            Color = "orange";
            PassengerOccupancy = 12;
        }
       
        public override void Go()
        {
            Console.WriteLine($"We will venture out on my ship, {Name}.");
        }
        public void Refuel()
        {
            Console.WriteLine($"{Name} is running low on gas, so we'll need to refuel soon.");
        }
    }
}
