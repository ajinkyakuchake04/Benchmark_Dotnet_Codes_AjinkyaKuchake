using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2_Enumeration
{
     class Program
    {
        enum Days {Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday}
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("The required values of days are as follows: ");
            p.PrintDay();
            Console.ReadKey();
        }

        public void PrintDay()
        {
            Console.WriteLine("The value for Sunday is:" + (int)(Days.Sunday));
            Console.WriteLine("The value for Monday is:" + (int)(Days.Monday));
            Console.WriteLine("The value for Tuesday is:" + (int)(Days.Tuesday));
            Console.WriteLine("The value for Wednesday is:" + (int)(Days.Wednesday));
            Console.WriteLine("The value for Thursday is:" + (int)(Days.Thursday));
            Console.WriteLine("The value for Friday is:" + (int)(Days.Friday));
            Console.WriteLine("The value for Saturday is:" + (int)(Days.Saturday));
        }
    }
}
