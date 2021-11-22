using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3_SealedDemo
{
    //sealed class Parent 
    //{
    //    public void Display()
    //    {
    //        Console.WriteLine("Demo Parent Method");
    //    }
    //}

    //class Child : Parent        //cannot derive from sealed class parent
    //{
    //    public override void Display()
    //    {
    //        Console.WriteLine("Overridden method");
    //    }
    //}

    /*
    class Parent
    { 
        public virtual void Display()
        {
            Console.WriteLine("Parent Display Method");
        }
    }

    class Child : Parent
    {
        public sealed override void Display()
        {
            Console.WriteLine("Inside Child Display Class");
        }
    }

    class GrandChild : Child
    {
        public override void Display()                  ////cannot override from sealed child method
        {
            Console.WriteLine("Inside The Grand Child Display Method");
        }
    }
    */

    //hence Verified

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    }
