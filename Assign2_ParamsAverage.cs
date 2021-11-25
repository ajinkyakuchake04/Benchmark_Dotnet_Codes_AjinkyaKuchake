using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2_ParamsAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Final Averages:");
            p.PrintAverage(1,2,3,4,5,6,7,8,9,10);
            p.PrintAverage(11, 22, 33, 44, 55);
            p.PrintAverage(100,200,300,400,500,600);

            Console.ReadKey();
        }

        public void PrintAverage(params double[] arr)
        { 
            double sum = 0;
            double avg = 0;

            foreach  (double num in arr)
            {
                sum = sum + num;
            }

            avg = sum / arr.Length;
            Console.WriteLine("The required average is: "+avg);
        }
    }
}
