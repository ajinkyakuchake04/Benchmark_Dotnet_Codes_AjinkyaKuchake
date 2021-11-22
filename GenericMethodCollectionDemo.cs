using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodCollectionDemo
{
    internal class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int x, y;
            char ch1, ch2;

            x = 10;
            y = 20;

            ch1 = 'M';
            ch2 = 'N';

            Console.WriteLine();

            Console.WriteLine("Before swapping integers: x={0} y={1}",x,y);
            Swap(ref x,ref y);
            Console.WriteLine("After swapping integers: x={0} y={1}", x, y);
            Console.WriteLine("***************************************************");

            Console.WriteLine("Before swapping integers: ch1={0} ch2={1}",ch1,ch2);
            Swap(ref ch1, ref ch2);
            Console.WriteLine("After swapping integers: ch1={0} ch2={1}", ch1, ch2);

            Console.ReadKey();
        }
    }
}
