using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializes string lists
            string[] plants = { "Buttercups", "Sunflowers", "Romanesco Broccoli", "Artichoke", "Ginger" };
            string[] copy = { "Buttercups", "Sunflowers", "Romanesco Broccoli", "Artichoke", "Ginger" };
            string[] duplicate = { "Buttercups", "Sunflowers", "Romanesco Broccoli", "Artichoke", "Ginger", "Ginger" };

            //adds user input to each item in plants
            for (int p = 0; p < plants.Length; p++)
            {
                Console.WriteLine("Add your text to: " + plants[p] + "\n");
                string custom = Console.ReadLine();
                plants[p] = plants[p] + " " + custom;
            }

            //lists plants with user input appended
            foreach (string plant in plants)
            {
                Console.WriteLine(plant + "\n");
            }

            //gets user search, searches through items in copy
            Console.WriteLine("Search for an item on the list (Example: Cactus): ");
            string search = Console.ReadLine();
            bool found = false; // creates flag to check if item was found

            for (int s = 0; s < copy.Length; s++)
            {
                if (search == copy[s])
                {
                    Console.WriteLine("\nIndex = " + s + " (" + copy[s] + ")");
                    found = true;
                } 
            }

            //notifies user if their item did not was not on the list
            if (found == false)
            {
                Console.WriteLine("Your plant was not found on the list");
            }

            //gets user search, searches through items in duplicate
            Console.WriteLine("Search for an item on the list (Example: Cactus): ");
            string searchTwo = Console.ReadLine();
            bool foundTwo = false; // creates flag to check if item was found

            for (int d = 0; d < duplicate.Length; d++)
            {
                if (searchTwo == duplicate[d])
                {
                    Console.WriteLine("\nIndex = " + d + " (" + duplicate[d] + ")\n");
                    foundTwo = true;
                }
            }

            if (foundTwo == false)
            {
                Console.WriteLine("Your plant was not found on the list");
            }

            Console.ReadLine();

            //creates list to check if an item is duplicated
            List<string> check = new List<string>();
            
            //checks items one at a time, listing whether or not they have been
            //duplicated by seeing if the check list contains it
            foreach (string item in duplicate)
            {
                if (!check.Contains(item))
                {
                    Console.WriteLine(item + " - This item is unique");
                    check.Add(item);
                }
                else
                {
                    Console.WriteLine(item + " - This item is a duplicate");
                }
            }

            Console.ReadLine();

            for (int i = 0; i <= 10; i++) // <= operator practice
            {
                Console.WriteLine(i);
            }

            bool go = true;
            int c = 0;
            while (go == true)
            {
                // if (c > -1) causes infinite loop
                if (c < 1) // fixes loop with < operator
                {
                    Console.WriteLine("Are you ready for planting?");
                    c++; // ensures counter increases and closes loop
                }
                else
                {
                    Console.ReadLine();
                    System.Environment.Exit(1);
                }
            }


            //int[] testScores = { 89, 78, 66, 88, 90, 95, 99, 92, 66, 51, 68 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //   }
            //    Console.ReadLine();

            //string[] name = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < name.Length; j++)
            //{
            //    if (name[j] == "Adam" | name[j] == "Erik")
            //    {
            //        Console.WriteLine(name[j]);
            //        Console.ReadLine();
            //    }
            //}

            //List<int> testScores = new List<int>();
            //testScores.Add(88);
            //testScores.Add(77);
            //testScores.Add(99);
            //testScores.Add(95);
            //testScores.Add(80);
            //testScores.Add(75);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    if (name =="Jesse" | name == "Adam")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>() { 98, 90, 86, 77, 70, 50, 81, 100 };
            //List<int> passingScores = new List<int>();
            //
            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //   {
            //        passingScores.Add(score);
            //    }
            //}
            //
            //Console.WriteLine(passingScores.Count);
            //Console.ReadLine();
        }
    }
}
