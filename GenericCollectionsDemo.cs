using System;
using System.Collections.Generic;//generic present
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if data is not fixed use non-generic
            //if data is fixed use generic

            //ArrayList in non-generic is same as List in generic
            //there is no Hashtable in generic

            //List<int> list = new List<int>();//will accept only int
            //list.Add(10);
            //list.Add('a');
            //list.Add(20);
            //list.Add(30);
            //list.Add(40);
            //list.Add(50);

            //list.Sort();
            //Console.WriteLine();
            //list.Reverse();
            //Console.WriteLine();

            //list.Insert(3,59);
            //Console.WriteLine();

            //list.Remove(20);

            //foreach (int o in list)
            //{
            //    Console.WriteLine(o);
            //}

            //Queue<int> q= new Queue<int>();
            //q.Enqueue(10);
            //q.Enqueue(20);
            //q.Enqueue(30);
            //q.Enqueue(40);
            //q.Enqueue(50);

            //foreach (int o in q)
            //{
            //    Console.WriteLine(o);
            //}


            //Stack<string> s = new Stack<string>();
            //s.Push("Ajinkya");
            //s.Push("Ajinkya");
            //s.Push("Ajinkya");
            //s.Push("Ajinkya");
            //s.Push("Ajinkya");

            //foreach  (string o in s)
            //{
            //    Console.WriteLine(o);
            //}

            //Dictionary<int, string> d = new Dictionary<int, string>();
            //d.Add(1, "Ajinkya");
            //d.Add(2, "Guru");
            //d.Add(3, "Ajuu");

            //foreach (KeyValuePair<int,string> de in d)
            //{
            //    Console.WriteLine(de.Key+" "+de.Value);
            //}



            Console.ReadKey();
        }
    }
}
