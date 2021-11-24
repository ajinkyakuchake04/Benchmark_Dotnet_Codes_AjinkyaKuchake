using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Calling
{
    internal class Program
    {
        class Employee
        {
            int empno;
            string ename, department;

            public Employee(int no, string name, string dept)
            {
                empno = no;
                ename = name;
                department = dept;
            }

            public Employee(int eno, string enm):this(eno,enm,"Not Assigned")
            { 
                
            }

            public override string ToString()
            {
                return "Empno: " + empno + " Ename:" + ename + " Department: " + department;
                //return base.ToString();
            }

            public override bool Equals(object obj)
            {
                Employee e;
                if (obj.GetType() == typeof(Employee))
                {
                    e = (Employee)obj;
                }
                else
                {
                    Console.WriteLine("Objects are not of same type");
                    return false;
                }
                    if (this.empno == e.empno && this.ename == e.ename && this.department == e.department)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    //return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public void PrintData()
            {
                Console.WriteLine("Empno: "+empno+" Ename:"+ename+" Department: "+department);            
            }
        }

        static void Main(string[] args)
        {
            Employee e = new Employee(100,"Ajinkya");
            e.PrintData();
            Employee emp = new Employee(101, "Guru", "Sales Department");
            emp.PrintData();
            Console.WriteLine(e);

            //Console.WriteLine(e.GetType()); //this method cannot be overriden
            //Console.WriteLine(e.GetHashCode());//this method can be overriden

            Employee emp1 = new Employee(100,"Ajinkya");
            
            //if (emp == emp1)    //It will give result as objects are diffent
            //{
            //    Console.WriteLine("Objects are same");
            //}
            //else
            //{
            //    Console.WriteLine("Objects are different");
            //}

            if (e.Equals(emp1)) //It will return objects are same
            {
                Console.WriteLine("Objects are same");
            }
            else
            {
                Console.WriteLine("Objects are different");
            }

            if (e.Equals("Hello")) //It compiles perfectly since string is object but give InvalidCastException at runtime 
            {
                Console.WriteLine("Objects are same");
            }
            else
            {
                Console.WriteLine("Objects are different");
            }


            Console.ReadKey();
        }
    }
}
