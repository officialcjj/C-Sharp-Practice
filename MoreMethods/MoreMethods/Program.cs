using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your car's speed in miles per hour:");
            // instantiates class with user input as speed
            Car car = new Car(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter your car's acceleration in feet per second per second (optional):");
            car.acceleration = Console.ReadLine();
            // checks for user input, sets acceleration to 0 if empty
            if (string.IsNullOrEmpty(car.acceleration))
            {
                car.acceleration = "0";
            }

            // determines speed in 10 minutes if acceleration is consistent
            int futureSpeed = car.speed + ((Convert.ToInt32(car.acceleration)) * (180/43)); // converts from ft/s/s to mi/h/10min

            Console.WriteLine("Current speed: {0}mph", car.speed);
            Console.WriteLine("Speed in 10 minutes: {0}mph", futureSpeed);

            int addThickness = 0; // adds default value
            Console.WriteLine("Enter your wheel's diameter in inches:");
            Wheel wheel = new Wheel(Convert.ToInt32(Console.ReadLine()), addThickness);
            Console.WriteLine("Enter your tire's thickness in inches:");
            wheel.thickness = Convert.ToInt32(Console.ReadLine()); //updates thickness from default

            Wheel.Describe(wheel.diameter, wheel.thickness);
            Console.ReadLine();
        }
    }
}
