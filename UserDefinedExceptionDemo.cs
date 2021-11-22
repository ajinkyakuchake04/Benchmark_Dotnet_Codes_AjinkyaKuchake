using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExceptionDemo
{
    class InsufficientFundException : ApplicationException
    {
        public InsufficientFundException(string s):base(s)
        {
           
        }
        public void PrintErr()
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
    class Account
    {
        double bal;
        public Account(double b)
        {
            this.bal = b;
        }
        public void Deposit(double amt)
        {
            bal = bal + amt;
            Console.WriteLine("Deposited {0} Balance is {1}",amt,bal);
        }

        public void Withdraw(double amt)
        {
            if (bal < amt)
            {
                InsufficientFundException ife = new InsufficientFundException("Funds are insufficient");
                throw ife;
            }
            else
            {
                bal = bal - amt;
                Console.WriteLine("Withdrawn {0} Balance is {1}", bal, amt);
            }
        }

        public void PrintBalance()
        {
            Console.WriteLine("Balance is {0}",bal);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Account acc = new Account(10000);
                acc.PrintBalance();
                acc.Deposit(5000);
                acc.Withdraw(7000);
                acc.Withdraw(9000);
            }
            catch (InsufficientFundException i)
            {
                Console.WriteLine("Caught Exception: {0}",i.Message);
            }

            Console.ReadKey();
        }
    }
}
