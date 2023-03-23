using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // First Function
            // Console.WriteLine("What is your name?");
            // string name = Console.ReadLine();
            // Console.WriteLine("Hello, " + name + "!");
            // Console.Read();

            // Console.WriteLine("What is your favorite number?");
            // string Number = Console.ReadLine();
            // int intNum = Convert.ToInt32(Number);
            // int addNum = intNum + 5;
            // Console.WriteLine("Your favorite number is: " + intNum);
            // Console.WriteLine("Your favorite number plus 5 is: " + addNum);
            // Console.ReadLine();

            bool isStudying = false;

            byte hoursWorked = 42;

            sbyte currentTemperature = -23;

            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.30202092;

            float secondsLeft = 2.62f;

            short temperatureOnMars = -341;
            
            string myName = "Charlie";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingstatus = Convert.ToString(isRaining);

            Console.WriteLine(isStudying);
            Console.WriteLine(hoursWorked);
            Console.WriteLine(currentTemperature);
            Console.WriteLine(questionMark);
            Console.WriteLine(moneyInBank);
            Console.WriteLine(heightInCentimeters);
            Console.WriteLine(secondsLeft);
            Console.WriteLine(temperatureOnMars);
            Console.WriteLine(myName);
            Console.WriteLine(yearsOld);
            Console.WriteLine(isRaining);

            Console.ReadLine();
        }
    }
}
