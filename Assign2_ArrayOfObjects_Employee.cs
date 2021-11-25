using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2_ArrayOfObjects_Employee
{
    class Employee
    {
        int empno, salary;
        string designation, ename;

        public void AcceptDetails()
        {
            Console.WriteLine();
            Console.Write("Enter the Employee's Number: ");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Employee's Name: ");
            ename = Console.ReadLine();
            Console.Write("Enter the Employee's Designation: ");
            designation = Console.ReadLine();
            Console.Write("Enter the Employee's Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine();
            Console.WriteLine("employee Details:");
            Console.WriteLine("Employee's Number is:{0}", empno);
            Console.WriteLine("Employee's Name is:{0}", ename);
            Console.WriteLine("Employee's Designation is:{0}", designation);
            Console.WriteLine("Employee's Salary is:{0}", salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[10];
            for (int i = 0; i < 10; i++)
            {
                emp[i] = new Employee();
                emp[i].AcceptDetails();
                emp[i].DisplayDetails();
            }

            Console.ReadKey();
        }
    }
}
