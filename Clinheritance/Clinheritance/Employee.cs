using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinheritance
{
    public class Employee : Person, IQuittable
    {
        public int Id;
        public Employee(string AddFname, string AddLname, int AddId)
        {
            Fname = AddFname;
            Lname = AddLname;
            Id = AddId;
        }

        public List<Employee> Employees { get; set; }

        public static bool operator ==(Employee employee, Employee employee1)
        {
            return employee.Id == employee1.Id;
        }

        public static bool operator !=(Employee employee, Employee employee1)
        {
            return employee.Id != employee1.Id;
        }
        public void Quit(Employee employee)
        {
            Environment.Exit(0);
        }
    }
}
