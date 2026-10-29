using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_c_9
{
    internal class Box<T>
    {
        private T _item;

        public void Put(T item)
        { _item = item; }

        public T Get() 
        { return _item; }
    }
}
