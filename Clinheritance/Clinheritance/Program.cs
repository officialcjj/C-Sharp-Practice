using System;

namespace Clinheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Sample", "Student", 0);
            Student student = new Student("Homie", "Jones", 0);
            employee.SayName();
            student.SayName();
            Console.WriteLine("Exit Program? (Enter 'Yes' to exit program)");
            string answer = Console.ReadLine();
            while (answer != "Yes")
            {
                Console.WriteLine("Exit Program? (Enter 'Yes' to exit program)");
                answer = Console.ReadLine();
            }
            employee.Quit(employee);
        }
    }
}
