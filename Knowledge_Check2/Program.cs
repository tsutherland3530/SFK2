using System;
using System.Collections.Generic;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<CatFood>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                var catFood = new CatFood();

                Console.WriteLine("Enter the Name: ");
                catFood.Name = Console.ReadLine();

                Console.WriteLine("Enter the Price: ");
                catFood.Price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Quantity: ");
                catFood.Quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Description: ");
                catFood.Description = Console.ReadLine();

                Console.WriteLine("Is this food for kittens? (true/false): ");
                catFood
}