using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3_AbstractAccount
{
    public abstract class Account
    {
        public abstract void CalculateInterest();
    }

    class Saving : Account
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("The Saving Account Interest");
        }
    }

    class Current : Account
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("The Current Account Interest");
        }
    }

    class FD : Account
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("The FD account interest");
        }
    }


    internal class Program
    {
        public void CallFun(Account a)
        {
            a.CalculateInterest();
        }

        static void Main(string[] args)
        {

            Program p = new Program();

            Saving s = new Saving();
            Current c = new Current();
            FD f = new FD();

            p.CallFun(s);
            p.CallFun(c);
            p.CallFun(f);

            Console.ReadKey();
        }
    }
}
