using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Your_Garage.Vehicle;

namespace Your_Garage
{
    abstract class Aircraft : VehicleBase
    {
        
        public string Name { get; set; }

        public Aircraft(string name)
        {
            FuelCapacity = 300;
            Color = "Red";
            PassengerOccupancy = 25;
        }

        public override void Go()
        {
            Console.WriteLine($"We flew out of Nashville on my {Name} around noon and are headed to Orlando.");
        }
        public override void Stop()
        {
            Console.WriteLine($"We landed just in time and only used about half of our {FuelCapacity}-gallon tank of fuel.");
        }
    }
}
