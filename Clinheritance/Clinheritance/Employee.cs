using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinheritance
{
    public class Employee<T> : Person, IQuittable<T>
    {
        
        public int Id;
        public T Desc;
        public List<T> Things;
        public Employee(string AddFname, string AddLname, int AddId, T AddDesc)
        {
            Fname = AddFname;
            Lname = AddLname;
            Id = AddId;
            Desc = AddDesc;
            Things = new List<T> {  };
        }

        public static bool operator ==(Employee<T> employee, Employee<T> employee1)
        {
            return employee.Id == employee1.Id;
        }

        public static bool operator !=(Employee<T> employee, Employee<T> employee1)
        {
            return employee.Id != employee1.Id;
        }
        public void Quit(Employee<T> employee)
        {
            Environment.Exit(0);
        }
    }
}
