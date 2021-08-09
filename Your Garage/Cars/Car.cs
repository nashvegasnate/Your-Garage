using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Your_Garage.Vehicle;

namespace Your_Garage
{
    abstract class Car : VehicleBase
    {

        public Car(string color, int passengerOccupancy)
        {
            FuelCapacity = 30;
            PassengerOccupancy = passengerOccupancy;
            Color = color;
        }

        public override void Go()
        {
            Console.WriteLine($"Driving the car.");
        }
        public override void Stop()
        {
            Console.WriteLine($"Applying the brakes now.");
        }

    }
}
