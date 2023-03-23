using System;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // prints current time
            Console.WriteLine(DateTime.Now);
            // gets user input
            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            // makes new datetime variable, assigns its values to x hours and minutes from current time and prints
            DateTime inxhoursminutes = new DateTime();
            inxhoursminutes = DateTime.Now.AddHours(x).AddMinutes(x);
            Console.WriteLine("In {0} hours and {0} minutes, the time will be " + inxhoursminutes, x);

            Console.ReadLine();
        }
    }
}
