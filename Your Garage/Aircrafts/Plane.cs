using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Garage.Aircrafts
{
    class Plane : Aircraft
    {
        public Plane(string color)
        {
            FuelCapacity = 75;
            Color = color;
            PassengerOccupancy = 10;
        }
    }
}
