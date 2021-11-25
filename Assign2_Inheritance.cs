using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2_Inheritance
{
    class Employee
    {
        int empid;
        string name;

        public Employee(int empid, string name)
        { 
            this.empid = empid;
            this.name = name;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee Id:"+empid+" Employee Name: "+name);
        }
    }

    class PermanentEmployee : Employee
    {
        double HRA,DA,basic,gross_sal;

        public PermanentEmployee(int empid, string name, double basic) : base(empid, name)
        {
            this.basic = basic;
        }

        public void CalcSalary()
        {
            HRA = basic * 0.5;
            DA = basic * 0.3;
            gross_sal = basic + HRA + DA;
            base.DisplayDetails();
            Console.WriteLine("The gross salary of the Permanent employee is:{0} Rs/-",gross_sal);
        }

    }

    class WagedEmployee : Employee
    {
        int hours;
        double amount;
        double salary;

        public WagedEmployee(int empid, string name, int hours, double amount):base(empid,name)
        {
            this.hours = hours;
            this.amount = amount;

        }

        public void CalcSal()
        {
            salary = hours * amount;
            base.DisplayDetails();
            Console.WriteLine("The salary of the Waged Employee is:{0} Rs/-",salary);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployee emp1 = new PermanentEmployee(101,"Ajinkya",500000);
            WagedEmployee emp2 = new WagedEmployee(102, "Guru", 5, 100);

            emp1.CalcSalary();
            Console.WriteLine();
            emp2.CalcSal();

            Console.ReadKey();
        }
    }
}
