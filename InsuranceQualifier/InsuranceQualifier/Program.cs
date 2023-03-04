using System;

namespace InsuranceQualifier
{
    class Program
    {
        static void Main()
        {
            // Greets user, lets them start when ready
            Console.WriteLine("Press Enter to see if you're qualified for car insurance!");
            Console.ReadLine();

            // Gets necessary info from user
            Console.WriteLine("What is your age?\n");
            string Age = Console.ReadLine();
            int intAge = Convert.ToInt32(Age);
            Console.WriteLine("\nHave you ever had a DUI? (Enter 'true' or 'false')\n");
            string Dui = Console.ReadLine();
            bool boolDui = Convert.ToBoolean(Dui);
            Console.WriteLine("\nHow many speeding tickets do you have?\n");
            string Tickets = Console.ReadLine();
            int intTickets = Convert.ToInt32(Tickets);

            // Processes user info and returns result
            bool Qualified = intAge > 15 && boolDui == false && intTickets <= 3;
            Console.WriteLine("\nQualified?\n" + Qualified);
            Console.ReadLine();
        }
    }
}
