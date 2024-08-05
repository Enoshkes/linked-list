using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.List
{
    internal class ELinkedList<T> : EList<T>
    {
        private ENode<T>? _head;
        public int Length { get; private set; }

        public T? Get(int index)
        {
            if (index < 0 || index >= Length)
            {
                return default;
            }

            ENode<T>? current = _head;
            for (int i = 0; i < index; i++)
            {
                current = current!.Next;
            }
            return current!.Value;
        }

        public T? Pop()
        {
            if (Length == 0) { return default; }
            if (Length == 1)
            {
                T x = _head!.Value;
                _head = null;
                Length--;
                return x;
            }
            ENode<T>? temp = _head;
            while (temp!.Next!.Next != null)
            {
                temp = temp.Next;
            }
            T value = temp.Next.Value;
            temp.Next = null;
            Length--;
            return value;
        }

        public void Push(T item)
        {
            ENode<T> newNode = new(item);
            if (Length == 0)
            {
                _head = newNode;
            }
            else
            {
                ENode<T> temp = _head!;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
            Length++;
        }

        public T? Shift()
        {
            if (Length == 0) { return default; }
            T value = _head!.Value;
            _head = _head.Next;
            Length--;
            return value;
        }

        public void Unshift(T item)
        {
            ENode<T> newNode = new(item);
            newNode.Next = _head;
            _head = newNode;
            Length++;
        }

        public override string ToString()
        {
            ENode<T>? temp = _head;

            if (temp == null) return "[]";
            if (temp.Next == null) { return $"[{_head.Value}]"; }
            string str = "[";

            while (temp != null)
            {
                str += temp.Next == null ? $"{temp.Value}" : $"{temp.Value}, ";
                temp = temp.Next;
            }
            return $"{str}]";
        }
    }
}
