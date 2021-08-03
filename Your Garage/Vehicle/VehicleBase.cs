using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Garage.Vehicle
{
    abstract class VehicleBase
    {
        public int FuelCapacity { get; set; }
        public string Color { get; set; }
        public int PassengerOccupancy { get; set; }
    }

    public virtual void Refuel()
    {
        Console.WriteLine("Getting gas!");
    }

    public abstract void Go();
    public abstract void Stop();
}
