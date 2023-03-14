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
            Console.ReadLine();
        }
    }
}
