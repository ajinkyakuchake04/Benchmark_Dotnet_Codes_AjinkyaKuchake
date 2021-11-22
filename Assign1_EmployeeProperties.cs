using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1_EmployeeProperties
{
    class Employee
    {
        int empno;
        string ename, designation;

        public int Empno
        {
            set{
                if (empno < 0)
                {
                    Console.WriteLine("Invalid Employee Number");
                }
                else
                {
                    empno = value;
                }
            }
            get{
                return empno;
            }
        }

        public string Ename
        {
            set
            {
                ename = value;
            }
            get
            {
                return ename;
            }
        }

        public string Designation
        {
            set
            {
                designation = value;
            }
            get
            {
                return designation;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Empno = 111;
            e.Ename = "Ajinkya Kuchake";
            e.Designation = "Full Stack Developer";

            Console.WriteLine("Employee Deatails are as follows:");
            Console.WriteLine("Employee number: {0}",e.Empno);
            Console.WriteLine("Employee Name: {0}", e.Ename);
            Console.WriteLine("Employee designation: {0}",e.Designation);

            Console.ReadKey();
        }
    }
}
