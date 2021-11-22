using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedGenericClassesCollections
{
    class MathClass<T>   //Generic class creation using data with T type
    {
        public T add(int a, int b)
        {
            return a + b;
        }
        public T subtract(int a, int b)
        {
            return a - b;
        }
    }
    internal class Program
    { 
        static void Main(string[] args)
        {
            MathClass obj = new MathClass();
            Console.WriteLine(obj.add(1, 10));
            Console.WriteLine(obj.subtract(10,5));

            Console.ReadKey();
        }
        //creating genric class means creating class with flexible data types
    }
}
