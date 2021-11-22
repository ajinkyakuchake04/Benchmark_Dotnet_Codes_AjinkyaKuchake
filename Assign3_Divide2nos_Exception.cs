using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3_Divide2nos_Exception
{


    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double res;
            Console.WriteLine("Enter the two numbers: ");
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
                res = (double)(num1 / num2);

                Console.WriteLine("The required result is: {0}", res);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception caught is: {0}",exp.Message);
            }

            finally
            {
                Console.WriteLine("The program got executed completely.");
            }
            Console.ReadKey();
        }
    }
}
