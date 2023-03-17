using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    public class ObjectClass
    {
        public string Name;
        public int ID;
        public ObjectClass():this("name")
        {
            //no parameters
        }
        public ObjectClass(string name):this(name, 0)
        {
            Name = name;
        }
        public ObjectClass(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}
