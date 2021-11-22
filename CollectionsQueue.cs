using System;
using System.Collections;//removed Generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(45);
            q.Enqueue(100);
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);

            //contains function
            if (q.Contains(30))
            {
                Console.WriteLine("Yes it contains 30");
            }
            else
            {
                Console.WriteLine("30 is not present");
            }


            foreach (object o in q)
            {
                Console.WriteLine(o);
            }

            Console.ReadKey();

        }
    }
}
