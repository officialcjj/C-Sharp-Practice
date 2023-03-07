using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // game 1, gets user input, loops until first answer is guessed
            Console.WriteLine("Guess a number: (Hint: 51/3)");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            while (!isGuessed)
            {
                switch (number)
                {
                    case 17:
                        Console.WriteLine("You guessed correctly! Good job!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Your guess, " + number + ", was wrong. Try again!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            // game 2, same functionality as game 1 but in a do while loop
            Console.WriteLine("\nGuess another number: (Hint: 3 squared, squared)");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            bool guessedTwo = false;

            do
            {
                switch (numberTwo)
                {
                    case 81:
                        Console.WriteLine("You guessed correctly! Good job!");
                        guessedTwo = true;
                        break;
                    default:
                        Console.WriteLine("Your guess, " + numberTwo + ", was wrong. Try again!");
                        numberTwo = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!guessedTwo);

            Console.Read();
        }
    }
}
