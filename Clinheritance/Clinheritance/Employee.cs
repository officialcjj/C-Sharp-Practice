using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinheritance
{
    public class Employee : Person
    {
        public int Id;
        public Employee(string AddFname, string AddLname, int AddId)
        {
            Fname = AddFname;
            Lname = AddLname;
            Id = AddId;
        }
    }
}
