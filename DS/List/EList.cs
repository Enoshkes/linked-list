using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.List
{
    internal interface EList<T>
    {
        void Push(T item);
        T? Pop();
        void Unshift(T item);
        T? Shift();
        T? Get(int index);
    }
}
