using System;
using System.Collections.Generic;

namespace ArraysandLists
{
    class Program
    {
        static void Main()
        {
            // creates a 4-string array and a 12-integer array
            string[] strArray = new string[4] { "John", "Paul", "Ringo", "George" };
            int[] intArray = new int[11] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            // prompts user to select index of string array
            Console.WriteLine("Select a Beatle! (Please enter a number from 0 to 3)");
            int strIndex = Convert.ToInt16(Console.ReadLine());

            // catches exceptions by checking if user input is in the array's domain
            while (strIndex > 3 | strIndex < 0)
            {
                Console.WriteLine("You have not chosen a valid index\nEnter an integer from 0 to 3 to continue:");
                strIndex = Convert.ToInt16(Console.ReadLine());
            }

            // returns item from string array
            Console.WriteLine("You've chosen " + strArray[strIndex] + "!");

            // allows user to read output before next input prompt
            Console.ReadLine();


            // prompts user to select index of integer array
            Console.WriteLine("Select a Fibonacci number! (Please enter a number from 0 to 10)");
            int intIndex = Convert.ToInt16(Console.ReadLine());

            while (intIndex > 10 | intIndex < 0)
            {
                Console.WriteLine("You have not chosen a valid index\nEnter an integer from 0 to 10 to continue:");
                intIndex = Convert.ToInt16(Console.ReadLine());
            }
            
            Console.WriteLine("You've chosen " + intArray[intIndex] + "!");

            Console.ReadLine();

            // creates list of strings
            List<string> strList = new List<string>();
            strList.Add("Buttercups");
            strList.Add("Sunflowers");
            strList.Add("Romanesco Broccoli");
            strList.Add("Artichoke");
            strList.Add("Ginger");

            // prompts user to select index of string list
            Console.WriteLine("Select a plant! (Please enter a number from 0 to 4)");
            int fibIndex = Convert.ToInt16(Console.ReadLine());

            while (fibIndex > 4 | fibIndex < 0)
            {
                Console.WriteLine("You have not chosen a valid index\nEnter an integer from 0 to 4 to continue:");
                fibIndex = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("You've chosen " + strList[fibIndex] + "!");

            Console.ReadLine();

            //List<int> intList = new List<int>();
            //intList.Add(0);
            //intList.Add(5);
            //intList.Add(10);
            //intList.Remove(10);

            //List<string> strList = new List<string>();
            //strList.Add("CJ");
            //strList.Add("Something");
            //strList.Add("ten");

            //Console.WriteLine(intList[0]);
            //Console.WriteLine(strList[2]);
            //Console.ReadLine();

            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
            //numArray2[5] = 650;

            //Console.WriteLine(numArray[3]);
            //Console.WriteLine(numArray1[4]);
            //Console.WriteLine(numArray2[5]);

            // byte[] byteArray = new byte[5000]
        }
    }
}
