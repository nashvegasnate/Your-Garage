using System;
using System.Collections.Generic;
using Your_Garage.Aircrafts;
using Your_Garage.Cars;
using Your_Garage.Watercrafts;

namespace Your_Garage
{
    class Program
    {
        public static void Main()
        {
            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            
            List<Aircraft> planeList = new List<Aircraft>();
            var cessna = new Plane("blue");
            var fokker = new Plane("grey");
            var boeing = new Plane("chartreuse");
            planeList.Add(cessna);
            planeList.Add(fokker);
            planeList.Add(boeing);

            List<Car> carList = new List<Car>();
            var bentley = new MyRide("orange");
            var jeep = new MyRide("olive green");
            var porsche = new MyRide("slate blue");
            carList.Add(bentley);
            carList.Add(jeep);
            carList.Add(porsche);

            List<Watercraft> boatList = new List<Watercraft>();
            var malibu = new Boat("green");
            var wakesetter = new Boat("red");
            var pontoon = new Boat("white");
            boatList.Add(malibu);
            boatList.Add(wakesetter);
            boatList.Add(pontoon);



            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
        }
    }
}
