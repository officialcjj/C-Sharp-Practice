using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsdPractice
{
    // creates an Object class
    public class Object
    {
        public int numberOne; // adds integer field to Object
        public decimal numberTwo;
        public string numberThree;
        public string name; // adds string field to Object
        public string quality;

        // constructor for Object
        public Object(string objectName, int objectOne, decimal objectTwo, string objectThree, string objectQuality)
        {
            name = objectName;
            numberOne = objectOne;
            numberTwo = objectTwo;
            numberThree = objectThree;
            quality = objectQuality;
        }

        public static int Addition(Object userObject, int added)
        {
            Console.WriteLine("Enter your first number as an integer:");
            userObject.numberOne = Convert.ToInt32(Console.ReadLine());
            added = userObject.numberOne + 10;
            Console.WriteLine("Your first number plus ten equals " + added); 
            return added;
        }

        public static int Multiplication(Object userObject, int multiplied)
        {
            Console.WriteLine("Enter your second number as a decimal:");
            userObject.numberTwo = Convert.ToDecimal(Console.ReadLine());
            multiplied = Convert.ToInt32(userObject.numberTwo * 10);
            Console.WriteLine("Your second number times ten equals " + multiplied);
            return multiplied;
        }

        public static int Division(Object userObject, int divided)
        {
            Console.WriteLine("Enter your third number as an integer:");
            userObject.numberThree = Console.ReadLine();
            divided = Convert.ToInt32(userObject.numberThree) / 4;
            Console.WriteLine("Your third number divided by four equals " + divided);
            return divided;
        }

        // allows user to update name of userOject
        public static string NameChange(Object userObject)
        {
            Console.WriteLine("Change the name of your object? (Enter 'Yes' or 'No')");
            string answer = Console.ReadLine();
            if (answer == "Yes") // prompts user to enter new name and update userObject.name
            {
                Console.WriteLine("Enter the new name for your object:");
                userObject.name = Console.ReadLine();
                Console.WriteLine("Your object's new name is: " + userObject.name);
                return userObject.name;
            }
            else // returns unupdated name
            {
                Console.WriteLine("Your object's name is still " + userObject.name);
                return userObject.name;
            }
        }
    }
}
