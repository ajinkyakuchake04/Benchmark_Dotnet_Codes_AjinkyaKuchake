using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3_ArrayIndexOutOfBoundException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 elements of array: ");
            try
            {
                for (int i = 0; i <= arr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception caught is: {0}",ex.Message);
            }

            Console.ReadKey();
        }
    }
}
