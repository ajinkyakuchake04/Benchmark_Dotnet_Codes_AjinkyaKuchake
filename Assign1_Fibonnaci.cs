using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1_Fibonnaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first_term = 0;
            int second_term = 1;
            int third_term;

            int num;
            Console.Write("Enter the number till which you wish to print the Fibonacci series: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The required Fibonnaci series is: ");
            Console.Write("{0}\t{1}\t",first_term,second_term);
            for (int i = 1; i <= num; i++)
            {
                third_term = first_term + second_term;
                if (third_term <= num)
                {
                    Console.Write(third_term + "\t");
                    first_term = second_term;
                    second_term = third_term;
                }
                else
                {
                    break;
                }
   
            }         
            Console.ReadKey();

        }
    }
}
