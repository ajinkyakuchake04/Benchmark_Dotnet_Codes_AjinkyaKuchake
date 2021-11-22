using System;
using System.Collections;//removed Generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(100);
            s.Push(200);
            s.Push(300);

            foreach (object o in s)
            {
                Console.WriteLine(o);
            }

            s.Pop();
            Console.WriteLine("After Popping (LIFO)");
            foreach (object o in s)
            {
                Console.WriteLine(o);
            }

            Console.ReadKey();
        }
    }
}
