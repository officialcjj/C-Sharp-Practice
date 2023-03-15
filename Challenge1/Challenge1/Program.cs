using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week:");
            string Today = Console.ReadLine();
            bool valid = false;
            while (valid == false)
            {
                valid = true;
                try
                {
                    if (Today == Convert.ToString(Day.Monday))
                    {
                        Today = Convert.ToString(Day.Monday);
                        Console.WriteLine("So it's " + Today + "!");
                    }
                    else if (Today == Convert.ToString(Day.Tuesday))
                    {
                        Today = Convert.ToString(Day.Tuesday);
                        Console.WriteLine("So it's " + Today + "!");
                    }
                    else if (Today == Convert.ToString(Day.Wednesday))
                    {
                        Today = Convert.ToString(Day.Wednesday);
                        Console.WriteLine("So it's " + Today + "!");
                    }
                    else if (Today == Convert.ToString(Day.Thursday))
                    {
                        Today = Convert.ToString(Day.Thursday);
                        Console.WriteLine("So it's " + Today + "!");
                    }
                    else if (Today == Convert.ToString(Day.Friday))
                    {
                        Today = Convert.ToString(Day.Friday);
                        Console.WriteLine("So it's " + Today + "!");
                    }
                    else if (Today == Convert.ToString(Day.Saturday))
                    {
                        Today = Convert.ToString(Day.Saturday);
                        Console.WriteLine("So it's " + Today + "!");
                    }
                    else if (Today == Convert.ToString(Day.Sunday))
                    {
                        Today = Convert.ToString(Day.Sunday);
                        Console.WriteLine("So it's " + Today + "!");
                    }
                    else
                    {
                        valid = false;
                        Console.WriteLine("Please enter an actual day of the week.");
                        Today = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            
        }
        public enum Day
        {
            Monday=1,
            Tuesday=2,
            Wednesday=3,
            Thursday=4,
            Friday=5,
            Saturday=6,
            Sunday=7
        }
    }
}
