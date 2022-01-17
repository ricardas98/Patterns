using System;
using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitorTourist visitorTourist = new VisitorTourist();

            List<Building> city = new List<Building>();

            PrivateHouse house1 = new PrivateHouse();
            PrivateHouse house2 = new PrivateHouse();
            PrivateHouse house3 = new PrivateHouse();

            BusStation station1 = new BusStation();
            BusStation station2 = new BusStation();

            CoffeeHouse coffee1 = new CoffeeHouse();
            CoffeeHouse coffee2 = new CoffeeHouse();
            CoffeeHouse coffee3 = new CoffeeHouse();

            city.Add(house1);
            city.Add(house2);
            city.Add(house3);

            city.Add(station1);
            city.Add(station2);

            city.Add(coffee1);
            city.Add(coffee2);
            city.Add(coffee3);

            foreach (Building building in city)
            {
                building.Accept(visitorTourist);
            }
        }
    }
}
