using System;

namespace Clinheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee = new Employee("Sample", "Student", 0);
            Employee employee1 = new Employee("Sample", "Employee", 1);
            Employee amos = new Employee("Amos", "Herringsworth", 0);
            Student student = new Student("Homie", "Jones", 0);
            IQuittable quittable = new Employee("sample", "sample", -1);

            employee.SayName();
            student.SayName();

            if (employee == amos)
            {
                Console.WriteLine("\"{0} {1}\" has the same employee ID number as \"{2} {3}\"", employee.Fname, employee.Lname, amos.Fname, amos.Lname);
            }
            if (employee != employee1)
            {
                Console.WriteLine("\"{0} {1}\" does not have the same ID number as \"{2} {3}\"", employee.Fname, employee.Lname, employee1.Fname, employee1.Lname);
            }

            Console.WriteLine("Exit Program? (Enter 'Yes' to exit program)");
            string answer = Console.ReadLine();
            while (answer != "Yes")
            {
                Console.WriteLine("Exit Program? (Enter 'Yes' to exit program)");
                answer = Console.ReadLine();
            }
            quittable.Quit(employee);
        }
    }
}
