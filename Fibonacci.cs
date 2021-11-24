using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first_term = 0;
            int second_term = 1;
            int num;
            int third_term;

            Console.WriteLine("Enter the number till which you want fibonacci series:");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The required Fibonacci series is as follows: ");
            Console.WriteLine(first_term);
            Console.WriteLine(second_term);

            third_term = first_term + second_term;

            while (third_term <= num)
            {
                Console.WriteLine(third_term);
                first_term = second_term;
                second_term = third_term;
                third_term = first_term + second_term;
            }

            Console.ReadKey();
;        }
    }
}
