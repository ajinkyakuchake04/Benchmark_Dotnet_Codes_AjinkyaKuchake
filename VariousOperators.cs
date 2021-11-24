using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arithmetic Operators");
            Console.WriteLine("Enter two numbers to perform arithmetic operations:");
            int a, b, res;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            res = a + b;
            Console.WriteLine("Required Addition is: {0}",res);

            res = a - b;
            Console.WriteLine("Required Subtraction is: {0}",res);

            res = a * b;
            Console.WriteLine("Required Multiplication is: {0}",res);

            res = a / b;
            Console.WriteLine("Required Division is: {0}",res);

            res = a % b;
            Console.WriteLine("Required Remainder is: {0}",res);

            int c = 10;
            Console.WriteLine("The original value of c is : {0}",c);

            Console.WriteLine("The value of c after post increment is: {0}",c++);
            Console.WriteLine("The value of d assigned pre incremented c is:{0}", ++c);

            int d = c;
            Console.WriteLine("The value of d assigned c is: {0}",d);

            Console.WriteLine("The value of d after post decrement is:{0}",d--);
            Console.WriteLine("The value of d after pre decremnet is:{0}",--d);
            
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Assignment Operator:");
            int e = 100;

            e += 5;
            Console.WriteLine("The answer for += operator:{0}",e);
            e -= 5;
            Console.WriteLine("The answer fo -= operator:{0}",e);
            Console.ReadKey();

            
        }
    }
}
