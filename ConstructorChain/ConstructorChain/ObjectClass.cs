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
        public ObjectClass()
        {
            //no parameters
        }
        public ObjectClass(string name)
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
