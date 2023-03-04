using System;

namespace MathPractice
{
    class Program
    {
        static void Main()
        {
            // Performs basic arithmetic
            int adding = 5 + 9;
            int subtracting = 17 - 10;
            int multiplying = 5 * 5;
            int dividing = 10 / 10;
            int remaining = 27 % 5;
            Console.WriteLine("Five plus nine = " + adding.ToString());
            Console.WriteLine("Seventeen minus ten = " + subtracting.ToString());
            Console.WriteLine("Five times five = " + multiplying.ToString());
            Console.WriteLine("Ten divided by ten = " + dividing.ToString());
            Console.WriteLine("The remainder of twenty-seven divided by five = " + remaining.ToString());


            // Performs arithemetic on input
            Console.WriteLine("\nInput your number");
            string a = Console.ReadLine();
            int input = Convert.ToInt32(a);
            int b = input + 10;
            Console.WriteLine("Your number plus ten = " + b.ToString());

            // Compares input
            bool greater = b > 15;
            bool lesser = input < 100;
            bool equal = b == 15;
            bool unequal = input != 5;
            Console.WriteLine("Is your number plus ten greater than fifteen?\n" + greater);
            Console.WriteLine("Is your number less than one hundred?\n" + lesser);
            Console.WriteLine("Is your number plus ten equal to fifteen?\n" + equal);
            Console.WriteLine("Is your number something other than five?\n" + unequal);

            Console.ReadLine();
        }
    }
}
