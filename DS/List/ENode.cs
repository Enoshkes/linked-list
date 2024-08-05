using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.List
{
    internal class ENode<T>(T value)
    {
        public T Value { get; set; } = value;
        public ENode<T>? Next { get; set; }
    }
}
