using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinheritance
{
    public abstract class Person
    {
        public string Fname;
        public string Lname;

        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", Fname, Lname);
        }
    }
}
