using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByRefDemo
{
    internal class Program
    {

        public  static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter two values:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping: x={0} y={1}", x, y);

            Swap(ref x, ref y); //Without using the ref keyword the values won't be swapped

            Console.WriteLine("After swapping: x={0} y={1}",x,y);
            Console.ReadKey();
        }
    }
}
