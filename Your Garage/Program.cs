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
            
            List<Aircraft> planes = new List<Aircraft>();
            var cessna = new Plane("Cessna", 162);
            var fokker = new Plane("Fokker", 50);
            var boeing = new Plane("Boeing", 737);
        
            foreach (var plane in planes)
            {
                plane.Go();
                plane.Stop();
                plane.Refuel();
            }

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()

            List<Car> cars = new List<Car>();
            var bentley = new MyRide(2018, "Bentley", "Flying Spur");
            var jeep = new MyRide(1976, "Jeep", "CJ");
            var porsche = new MyRide(1993, "Porsche", "Carrera");
            
            foreach (var car in cars)
            {
                car.Go();
                car.Stop();
            }

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()

            List<Watercraft> boats = new List<Watercraft>();
            var malibu = new Boat();
            var wakesetter = new Boat();
            var pontoon = new Boat();

            foreach (var boat in boats)
            {
                boat.Go();
                boat.Stop();
            }
            



            

            
        }
    }
}
