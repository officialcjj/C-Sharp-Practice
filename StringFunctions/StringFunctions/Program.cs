using System;
using System.Text;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates stringbuilder
            StringBuilder quote = new StringBuilder();
            // adds strings
            string one = "\"So anyway, I started ";
            string two = "blasting\"";
            string three = "\n\t\t-Frank Reynolds";

            // builds complete string
            quote.Append(one);
            two = two.ToUpper();
            quote.Append(two);
            quote.Append(three);

            Console.WriteLine(quote);
            Console.Read();
        }
    }
}
