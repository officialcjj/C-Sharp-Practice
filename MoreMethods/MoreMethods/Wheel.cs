using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    public class Wheel
    {
        public int diameter;
        public int thickness;

        public Wheel(int addDiameter, int addThickness)
        {
            diameter = addDiameter;
            thickness = addThickness;
        }

        public static void Describe(int diameter, int thickness)
        {
            int circumference = Convert.ToInt32(diameter * 3.14);
            Console.WriteLine("Wheel has a circumference of about {0} inches and tire thickness of {1} inches.", circumference, thickness);
        }
    }
}
