using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Garage.Cars
{
    class MyRide : Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public MyRide(int year, string make, string model) : base("Green", 8)
        {
            Year = year;
            Make = make;
            Model = model;

            Console.WriteLine($"My {Color} {Make} {Model} has a tank that holds {FuelCapacity} gallons of gas and can fit {PassengerOccupancy} people comfortably");
        }
    }
}
