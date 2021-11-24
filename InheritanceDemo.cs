using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PermanentEmp emp = new PermanentEmp(101,"Ajinkya","Developer",100000);
            emp.PrintSalary();
            WagedEmp emp1 = new WagedEmp(102,"Guru","Manager",10,200);
            emp1.PrintSalary();
            Console.ReadKey();
        }
    }

    class Employee 
    {
        int empno;
        string designation;
        string ename;

        public Employee(int empno, string ename, string designation)
        {
            this.empno = empno;
            this.ename = ename;
            this.designation = designation;
        }

        public void PrintData()
        {
            Console.WriteLine("EmpNo:"+empno+"  Empname:"+ename+"  Designation:"+designation);
        }
    }

    class PermanentEmp : Employee 
    {
        double basic_salary;
        public PermanentEmp(int empno, string ename, string designation, double basic_salary) : base(empno,ename,designation)
        {
            this.basic_salary = basic_salary;
        }

        public void PrintSalary()
        {
            double gross_salary;
            base.PrintData();
            gross_salary = basic_salary + (0.5 * basic_salary) + (0.3 * basic_salary);
            Console.WriteLine("The required salary is:{0}",gross_salary);
        }
    }

    class WagedEmp : Employee
    {
        double noofhour, hourlyamt;
        public WagedEmp(int empno, string ename, string designation, double noofhour,double hourlyamt) : base(empno, ename, designation)
        {
            this.noofhour = noofhour;
            this.hourlyamt = hourlyamt;
        }

        public void PrintSalary()
        {
            double gross_salary;
            base.PrintData();
            gross_salary = noofhour * hourlyamt;
            Console.WriteLine("The required salary is:{0}", gross_salary);
        }
    }
}
