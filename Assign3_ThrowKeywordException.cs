using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assign3_ThrowKeywordException
{


    internal class Program
    {

        public void Divide()
        {
            int a, b, res;
            Console.WriteLine("Enter the two numbers for division");

            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                res = a / b;
                Console.WriteLine("The required division is: {0}",res);
            }
            catch (DivideByZeroException d)
            {
                throw d;
            }
        }

        public void CallDivide()
        {
            try
            {
                Divide();
            }
            catch (DivideByZeroException d)
            { 
                throw d;
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            try
            {
                p.Divide();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }
    }
}