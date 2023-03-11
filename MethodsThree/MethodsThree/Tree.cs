using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsThree
{
    public class Tree
    {
        public decimal diameter;
        public Tree(decimal addDiameter)
        {
            diameter = addDiameter;
        }
        public static void Circle(Tree tree) // works without user input for pi
        {
            decimal radius = tree.diameter / 2;
            decimal circumference = tree.diameter * 3;
            Console.WriteLine("The tree's radius is {0} inches", radius);
            Console.WriteLine("The tree's circumference is roughly {0} inches", circumference);
        }

        public static void Circle(Tree tree, decimal pi) // uses user input for pi
        {
            decimal radius = tree.diameter / 2;
            decimal circumference = tree.diameter * pi;
            Console.WriteLine("The tree's radius is {0} inches", radius);
            Console.WriteLine("The tree's circumference is {0} inches", circumference);
        }

        public static void Area(Tree tree,  decimal pi, out decimal area) // calculates horizontal area of object
        {
            tree.diameter = Convert.ToInt32(tree.diameter);
            area = (tree.diameter / 2) * (tree.diameter / 2) * pi;
        }
    }
}
