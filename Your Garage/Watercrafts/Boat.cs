using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Garage.Watercrafts
{
    class Boat : Watercraft
    {
        public Boat(string color)
        {
            FuelCapacity = 35;
            Color = color;
            PassengerOccupancy = 8;
        }
    }
}
