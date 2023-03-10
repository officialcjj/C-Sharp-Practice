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
        public int number; // adds integer field to Object
        public string name; // adds string field to Object
        public string quality;

        // constructor for Object
        public Object(string objectName, int objectNumber, string objectQuality)
        {
            name = objectName;
            number = objectNumber;
            quality = objectQuality;
        }

        public static int Addition(Object userObject, int added)
        {
            added = userObject.number + 10;
            Console.WriteLine("Your object's number plus ten equals " + added); 
            return added;
        }

        public static int Multiplication(Object userObject, int multiplied)
        {
            multiplied = userObject.number * 10;
            Console.WriteLine("Your object's number times ten equals " + multiplied);
            return multiplied;
        }

        public static int Division(Object userObject, int divided)
        {
            divided = userObject.number / 4;
            Console.WriteLine("Your object's number divided by four equals " + divided);
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
