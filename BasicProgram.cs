using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int a, b, add_res,sub_res,mul_res,div_res;
            Console.WriteLine("Enter two numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            add_res = a + b;
            Console.WriteLine("The required addition result is: "+add_res);

            sub_res = a - b;
            Console.WriteLine("The required subtraction result is: " + sub_res);

            mul_res = a * b;
            Console.WriteLine("The required multiplication result is: " + mul_res);

            div_res = a / b;
            Console.WriteLine("The required result is: " + div_res);

            Console.ReadKey();
        }
    }
}
