using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationDemo
{
    internal class Program
    {
        enum Days {Sun=100,Mon,Tue,Wed,Thu,Fri,Sat };
        static void Main(string[] args)
        {
            Program p = new Program();
            p.PrintDay(Days.Sat);
            /*int startDate = (int)(Days.Mon);
            int lastDate  = (int)(Days.Sat);

            Console.WriteLine("First Day: {0}",startDate);
            Console.WriteLine("Last Day: {0}",lastDate);
            */
            Console.ReadKey();
        }

        void PrintDay(Days d)
        {
            Console.WriteLine(d);
        }
    }
}
