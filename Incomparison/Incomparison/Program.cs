using System;

namespace Incomparison
{
    class Program
    {
        static void Main()
        {
            // Get user input and convert from string to int32
            Console.WriteLine("Anonymous Income Comparison Program\n\nPerson 1\nEnter Person 1's hourly pay: ");
            string oneRate = Console.ReadLine();
            decimal intoneRate = Convert.ToDecimal(oneRate);
            Console.WriteLine("Enter Person 1's weekly hours: ");
            string oneHours = Console.ReadLine();
            decimal intoneHours = Convert.ToDecimal(oneHours);

            Console.WriteLine("\nEnter Person 2's hourly pay: ");
            string twoRate = Console.ReadLine();
            decimal inttwoRate = Convert.ToDecimal(twoRate);
            Console.WriteLine("Enter Person 2's weekly hours: ");
            string twoHours = Console.ReadLine();
            decimal inttwoHours = Convert.ToDecimal(twoHours);

            // Performs arithmetic on user input
            decimal oneAnnual = intoneRate * intoneHours * 52;
            decimal twoAnnual = inttwoRate * inttwoHours * 52;
            bool oneOrtwo = oneAnnual > twoAnnual;

            // Prints results of arithmetic
            Console.WriteLine("\nPerson 1 makes $" + oneAnnual + " per year");
            Console.WriteLine("Person 2 makes $" + twoAnnual + " per year");
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?\n" + oneOrtwo);
            Console.ReadLine();
        }
    }
}
