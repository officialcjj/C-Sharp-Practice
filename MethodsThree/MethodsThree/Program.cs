using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a tree's diameter in inches:");
            Tree tree = new Tree(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("Enter your preferred value for pi (optional):");
            string pi = Console.ReadLine();
            // if/else handles empty string pi
            if (string.IsNullOrEmpty(pi)){
                Tree.Circle(tree);
            }
            else
            {
                Tree.Circle(tree, Convert.ToDecimal(pi));
            }

            pi = "3.1415926"; // updates pi for reuse
            decimal area = 0; // sets default for area
            Tree.Area(tree, Convert.ToDecimal(pi), out area);
            Console.WriteLine("A circular slice of the tree would have an area of {0} square inches", area); // returns out area


            Console.ReadLine();
        }
    }
}
