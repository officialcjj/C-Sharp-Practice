using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> values = new List<int>() { 24, 50, 60, 64, 100 };
                //prompts user to enter a divisor
                Console.WriteLine("Pick a number.");
                int input = Convert.ToInt32(Console.ReadLine());

                //divides each item in values by input
                foreach (int value in values)
                {
                    int result = value / input;
                    Console.WriteLine(result);
                }

                Console.ReadLine();
            }
            //catches type exceptions
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            //catches input=0
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            //catches common errors
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
