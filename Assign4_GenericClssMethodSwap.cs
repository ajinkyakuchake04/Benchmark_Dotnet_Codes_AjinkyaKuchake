using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_GenericClssMethodSwap
{

    class SwapClass<T>   //Generic class creation using data with T type
    {
        public void Swap<S>(ref S a, ref S b)
        {
            S temp;
            temp = a;
            a = b;
            b = temp;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            SwapClass<T> obj = new SwapClass<T>();
            int x, y;
            char ch1, ch2;

            x = 100;
            y = 200;

            ch1 = 'P';
            ch2 = 'Q';

            Console.WriteLine();

            Console.WriteLine("Before swapping integers: x={0} y={1}", x, y);
            obj.Swap(ref x, ref y);
            Console.WriteLine("After swapping integers: x={0} y={1}", x, y);
            Console.WriteLine("***************************************************");

            Console.WriteLine("Before swapping characters: ch1={0} ch2={1}", ch1, ch2);
            obj.Swap(ref ch1, ref ch2);
            Console.WriteLine("After swapping characters: ch1={0} ch2={1}", ch1, ch2);

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
