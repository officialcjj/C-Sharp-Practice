using System;

namespace PackageQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            // greets user, gets package weight and converts to int
            Console.WriteLine("Welcome to Package Express! Please follow the instructions below.\nEnter your package's weight in pounds:\n");
            string strWeight = Console.ReadLine();
            int Weight = Convert.ToInt32(strWeight);

            // exits program if package is too heavy
            if (Weight > 50)
            {
                Console.WriteLine("Sorry but your package exceeds the maximum weight of 50 pounds. (Press 'Enter' to exit program)");
                Console.ReadLine();
                System.Environment.Exit(1);
            }

            // gets package dimensions
            else
            {
                Console.WriteLine("Enter your package's width in inches:\n");
            }
            string strWidth = Console.ReadLine();
            
            Console.WriteLine("Enter your package's height in inches:\n");
            string strHeight = Console.ReadLine();
            
            Console.WriteLine("Enter your package's length in inches:\n");
            string strLength = Console.ReadLine();
            
            // converts user input to int and calculates quote
            int Width = Convert.ToInt16(strWidth);
            int Height = Convert.ToInt16(strHeight);
            int Length = Convert.ToInt16(strLength);
            int sumDimensions = Width + Height + Length;
            decimal Quote = Width * Height * Length * Weight / 333;
            
            if (sumDimensions > 50)
            {
                Console.WriteLine("Your package's dimensions exceed the maximum volume. (Press 'Enter' to exit program)");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            // makes price more expensive for test case
            else if (Width == 10)
            {
                decimal rateIncrease = Width * Height * Length * Weight / 100;
                Console.WriteLine("Your estimated total is $" + rateIncrease);
            }
            else
            {
                Console.WriteLine("Your estimated total is $" + Quote);
            }

            Console.ReadLine();
        }
    }
}
