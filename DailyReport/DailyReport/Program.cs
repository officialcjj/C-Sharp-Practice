using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Writes title, asks and reads student name
            Console.WriteLine("The Tech Academy \n\nStudent Daily Report \n\nWhat is your name?");
            string studentName = Console.ReadLine();

            // Asks questions and reads corresponding variables
            Console.WriteLine("What course are you on?\n");
            string studentCourse = Console.ReadLine();

            Console.WriteLine("What page number?\n");
            string stringPage = Console.ReadLine();
            // Converts string stringPage to Int16 studentPage
            Int16 studentPage = Convert.ToInt16(stringPage);

            Console.WriteLine("Do you need help with anything? (Enter 'true' or 'false')\n");
            string stringHelp = Console.ReadLine();
            // Converts string stringHelp to bool studentHelp
            bool studentHelp = Convert.ToBoolean(stringHelp);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.\n");
            string studentExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.\n");
            string studentFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?\n");
            string stringHours = Console.ReadLine();
            Int16 studentHours = Convert.ToInt16(stringHours);

            // Thanks user for their answers
            Console.WriteLine("\nThank you for your answers. \nAn instructor will respond to this shortly.\nHave a great day!\n");

            // Relays formatted answers for review
            Console.WriteLine(studentName + " is on the " + studentCourse + " course, page " + studentPage + ", and studied for " + studentHours + " hours today.\n");
            Console.WriteLine("Needs Help: " + studentHelp + "\nPositive Experiences: " + studentExperience + "\nOther Feedback: " + studentFeedback);
            Console.ReadLine();
        }
    }
}
