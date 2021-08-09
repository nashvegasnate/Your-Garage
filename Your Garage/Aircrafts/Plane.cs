using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Garage.Aircrafts
{
    class Plane : Aircraft
    {
        public string Model { get; set; }
        public int ModelNumber { get; set; }
        public Plane(string model, int number) : base("Kittyhawk")
        {
            Model = model;
            ModelNumber = number;

            Console.WriteLine($"My {Model} {ModelNumber} is one of the lightest planes on the market.");
        }




    }
}
