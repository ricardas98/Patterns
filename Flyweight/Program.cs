using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            ForestContext forest = new ForestContext();

            forest.PlantTree("Oak", "brown", 15);
            forest.PlantTree("Oak", "brown", 12);
            forest.PlantTree("Oak", "brown", 5);
            forest.PlantTree("Oak", "brown", 3);
            forest.PlantTree("Oak", "brown", 20);
            forest.PlantTree("Oak", "brown", 17);

            forest.PlantTree("Birch", "black", 9);
            forest.PlantTree("Birch", "black", 5);
            forest.PlantTree("Birch", "black", 10);

            forest.PlantTree("Spruce", "dark brown", 25);
            forest.PlantTree("Spruce", "dark brown", 30);
            forest.PlantTree("Spruce", "dark brown", 22);

            forest.PlantTree("Oak", "black", 30);

            forest.DrawTrees();

            Console.WriteLine(forest.GetTreeCount());
            Console.WriteLine(forest.GetTypeCount());
        }
    }
}
