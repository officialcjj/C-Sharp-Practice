using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> employee = new Employee<string>("Sample", "Student", 0, "Not sure why their last name is student but so speaketh the program");
            employee.SayName();
            Employee<int> employee1 = new Employee<int>("Sample", "Employee", 1, 5);
            Employee<string> amos = new Employee<string>("Amos", "Herringsworth", 0, "Was actually supposed to have ID number 0. Has been around a while.");
            Employee<string> joe1 = new Employee<string>("Joe", "Ma", 2, "");
            Employee<string> joe2 = new Employee<string>("Joe", "Man", 3, "");
            Employee<string> joe3 = new Employee<string>("Joe", "Merry", 4, "");
            Employee<string> joe4 = new Employee<string>("Joe", "Horseman", 5, "");
            Employee<string> joe5 = new Employee<string>("Joe", "Asclepius", 6, "");
            Employee<string> joe6 = new Employee<string>("Joe", "Nantucket", 7, "");
            Employee<string> joe7 = new Employee<string>("Joe", "Joe", 8, "");
            Employee<string> joe8 = new Employee<string>("Joe", "of the Sky", 9, "");
            Employee<string> joe9 = new Employee<string>("Joe", "Herringsworth", 10, "Amos's son- He's a good kid");
            IQuittable<string> quitter = new Employee<string>("Quitter", "McQuitprogram", -1, "Why was I created? Just to quit?");

            List<Employee<string>> employees = new List<Employee<string>>() { employee, amos, joe1, joe2, joe3, joe4, joe5, joe6, joe7, joe8, joe9 };
            List<Employee<string>> joes = new List<Employee<string>>();
            foreach (Employee<string> e in employees)
            {
                if (e.Fname == "Joe")
                {
                    joes.Add(e);
                }
            }
            //foreach (Employee<string> joe in joes)
            //{
            //    Console.WriteLine(joe.Fname + " " + joe.Lname);
            //}

            List<Employee<string>> moreJoes = employees.FindAll(x => x.Fname == "Joe");
            //foreach (Employee<string> joe in moreJoes)
            //{
            //    Console.WriteLine(joe.Fname + " " + joe.Lname);
            //}

            List<Employee<string>> idList = employees.FindAll(x => x.Id > 5);
            foreach (Employee<string> e in idList)
            {
                Console.WriteLine(e.Fname + " " + e.Lname);
            }

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
