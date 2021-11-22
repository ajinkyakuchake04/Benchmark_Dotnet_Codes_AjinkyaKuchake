using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3_InterfaceDemo
{
    interface IPrintable
    {
        void Print();
    }

    class Account : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Interface within Account class");
        }
    }

    class Employee : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Interface within Employee class");
        }
    }

    internal class Program
    {
        public void callFun(IPrintable i)
        {
            i.Print();
        }

        static void Main(string[] args)
        {
            Account a = new Account();
            Employee e = new Employee();

            //a.Print();
            //e.Print();


            Program p = new Program();
            p.callFun(a);
            p.callFun(e);

            Console.ReadKey();
        }
    }
}
