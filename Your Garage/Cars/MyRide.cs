using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Garage.Cars
{
    class MyRide : Car
    {
        public MyRide(string color)
        {
            FuelCapacity = 20;
            Color = color;
            PassengerOccupancy = 5;
        }
    }
}
