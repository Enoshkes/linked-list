using DS.List;

namespace DS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EList<string> list = new ELinkedList<string>();
            list.Push("a");
            list.Push("b");
            list.Push("c");
            list.Unshift("o");
            var x = list.Get(19);
            Console.WriteLine(x);
        }
    }
}
