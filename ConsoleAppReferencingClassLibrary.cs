using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArithmeticLibrary;

namespace ConsoleAppReferencingClassLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticLibrary.MathClass obj = new ArithmeticLibrary.MathClass();
            Console.WriteLine("****Solutions****");
            Console.WriteLine("Addition is:"+obj.Add(10,5));
            Console.WriteLine("Subtraction is:"+obj.Subtract(10,5));
            Console.WriteLine("Multiplication is:"+obj.Multiply(10,5));
            Console.WriteLine("Division is:"+obj.Divide(10,5));

            Console.ReadKey();
        }
    }
}
