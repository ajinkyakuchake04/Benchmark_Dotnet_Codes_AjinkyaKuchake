using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_DateClassOverrideToStringEquals
{
    class DateClass
    {
        int day, year;
        string month;

        public DateClass(int day, string month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }


        public override string ToString()
        {
            return "Day: " + day + " Month:" + month + " Year: " + year;
            //return base.ToString();
        }

        public override bool Equals(object obj)
        {
            DateClass dc;
            if (obj.GetType() == typeof(DateClass))
            {
                dc = (DateClass)obj;
            }
            else
            {
                Console.WriteLine("Objects are not of same type");
                return false;
            }
            if (this.day == dc.day && this.month == dc.month && this.year == dc.year)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return base.Equals(obj);
        }

        public void PrintData()
        {
            Console.WriteLine("Day: " + day + " Month:" + month + " Year: " + year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateClass dc1 = new DateClass(4, "October", 1997);
            DateClass dc2 = new DateClass(4, "October", 1997);


            Console.WriteLine();
            if (dc1.Equals(dc2)) //It will return objects are same
            {
                Console.WriteLine("Objects are same");
                Console.Write("Date 1: ");
                dc1.PrintData();
                Console.Write("Date 2: ");
                dc2.PrintData();
                //Console.WriteLine(dc1);

            }
            else
            {
                Console.WriteLine("Objects are different");
                Console.Write("Date 1: ");
                dc1.PrintData();
                Console.Write("Date 2: ");
                dc2.PrintData();
            }

            Console.ReadKey();
        }
    }
}
