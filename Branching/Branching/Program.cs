using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the current temperature (\x00B0F)?\n");

            string stringTemperature = Console.ReadLine();
            int currentTemperature = Convert.ToInt32(stringTemperature);
            int roomTemperature = 70;

            string comparisonResult = currentTemperature == roomTemperature ? "It is room temp" : "It is not room temp";

            Console.WriteLine(comparisonResult);

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (currentTemperature < roomTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It is not room temperature");
            //}

            Console.ReadLine();
        }
    }
}
