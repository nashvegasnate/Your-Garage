using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Garage.Watercrafts
{
    class Boat : Watercraft
    {
        public Boat() : base("Mermaiden")
        {
            Console.WriteLine($"We are heading out on a three-hour tour in {Name}, which is the {Color} ship and can carry up to {PassengerOccupancy} people.");
        }

        public override void Stop()
        {
            Console.WriteLine($"I'm not sure exactly how to stop my {Name}.");
        }
    }
}
