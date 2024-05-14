using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("How many plants do you want to add?");
        int numberOfPlants = int.Parse(Console.ReadLine());

        var plants = new List<Plant>();
        for (int i = 0; i < numberOfPlants; i++)
        {
            Console.WriteLine("Type of plant (Tree/Flower):");
            string type = Console.ReadLine();

            if (type.ToLower() == "tree")
            {
                Tree tree = new Tree();
                Console.WriteLine("Enter the Name of the Tree:");
                tree.Name = Console.ReadLine();
                Console.WriteLine("Enter the Watering Schedule for the Tree:");
                tree.WaterSchedule = Console.ReadLine();
                Console.WriteLine("Enter the Height of the Tree (in meters):");
                tree.TreeHeight = double.Parse(Console.ReadLine());

                tree.PlantType = "Tree";
                plants.Add(tree);
            }
            else if (type.ToLower() == "flower")
            {
                Flower flower = new Flower();
                Console.WriteLine("Enter the Name of the Flower:");
                flower.Name = Console.ReadLine();
                Console.WriteLine("Enter the Watering Schedule for the Flower:");
                flower.WaterSchedule = Console.ReadLine();
                Console.WriteLine("Enter the Color of the Flower:");
                flower.Color = Console.ReadLine();
                Console.WriteLine("Is the Flower Perennial? (true/false):");
                flower.IsPerennial = bool.Parse(Console.ReadLine());

                flower.PlantType = "Flower";
                plants.Add(flower);
            }
        }

        // Print out the list of plants
        foreach (var plant in plants)
        {
            Console.WriteLine(plant);
        }
    }
}
