using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter the last number till which you wish to find out the prime numbers: ");
            num = Convert.ToInt32(Console.ReadLine());


            for (int i = 2; i < num; i++)
            {
                int temp = 0;

                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        temp = temp + 1;
                        break;
                    }
                }

                if (temp == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.ReadKey();
        }
    }
}
