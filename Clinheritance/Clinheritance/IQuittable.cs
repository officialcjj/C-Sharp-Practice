using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinheritance
{
    interface IQuittable<T>
    {
        void Quit(Employee<T> employee);
    }
}
