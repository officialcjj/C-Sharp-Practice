using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    class Program
    {
        static void Main(string[] args)
        {
            const string jesus = "Jesus was holey";
            var Jesus = "Like Swiss cheese";
            ObjectClass nullthing = new ObjectClass();
            ObjectClass thing = new ObjectClass("Charlie");
            ObjectClass thing2 = new ObjectClass("CJ", 1);
            Console.WriteLine(nullthing.Name + thing.Name + thing2.Name + thing2.ID + "... " + jesus + "... " + Jesus);
            Console.ReadLine();
        }
    }
}
