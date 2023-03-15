using System;

namespace Clinheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> employee = new Employee<string>("Sample", "Student", 0, "Not sure why their last name is student but so speaketh the program");
            Employee<int> employee1 = new Employee<int>("Sample", "Employee", 1, 5);
            Employee<string> amos = new Employee<string>("Amos", "Herringsworth", 0, "Was actually supposed to have ID number 0. Has been around a while.");
            Student student = new Student("Homie", "Jones", 0);
            IQuittable<string> quitter = new Employee<string>("Quitter", "McQuitprogram", -1, "Why was I created? Just to quit?");

            employee.SayName();
            student.SayName();

            if (employee.Id == amos.Id)
            {
                Console.WriteLine("\"{0} {1}\" has the same employee ID number as \"{2} {3}\"", employee.Fname, employee.Lname, amos.Fname, amos.Lname);
            }
            if (employee.Id != employee1.Id)
            {
                Console.WriteLine("\"{0} {1}\" does not have the same ID number as \"{2} {3}\"", employee.Fname, employee.Lname, employee1.Fname, employee1.Lname);
            }

            employee.Things.Add("Pencil");
            employee.Things.Add("Pencil Sharpener");
            employee.Things.Add("Monopoly Shoe");

            employee1.Things.Add(94460);
            employee1.Things.Add(37528);
            employee1.Things.Add(20495);

            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("Exit Program? (Enter 'Yes' to exit program)");
            string answer = Console.ReadLine();
            while (answer != "Yes")
            {
                Console.WriteLine("Exit Program? (Enter 'Yes' to exit program)");
                answer = Console.ReadLine();
            }
            quitter.Quit(employee);
        }
    }
}
