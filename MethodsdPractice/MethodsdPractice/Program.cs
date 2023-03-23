using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsdPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // gets user inputs
            Console.WriteLine("Create an object with a name, number, and quality!\nEnter a name:");
            string objectName = Console.ReadLine();
            Console.WriteLine("Enter a quality:");
            string objectQuality = Console.ReadLine();

            // creates and describes user object
            Object userObject = new Object(objectName, 0, 0, "0", objectQuality);
            Console.WriteLine("You created an object, " + userObject.name + ", with the quality " + userObject.quality);

            int added = 0; //initializes variable because static methods don't automatically
            added = Object.Addition(userObject, added); //sends user input and preinitialized variable to method
            Console.WriteLine(added);

            int multiplied = 0;
            multiplied = Object.Multiplication(userObject, multiplied);
            Console.WriteLine(multiplied);

            int divided = 0;
            divided = Object.Division(userObject, divided);
            Console.WriteLine(divided);

            // calls NameChange to update userObject.name
            Object.NameChange(userObject);

            Console.ReadLine();
        }
    }
}
