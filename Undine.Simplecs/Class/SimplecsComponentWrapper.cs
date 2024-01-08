using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undine.Simplecs.Class
{
    public struct SimplecsComponentWrapper<T> 
        where T : class
    {
        public T Component;
    }
}
