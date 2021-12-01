using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_EmployeeListGeneric
{
    class Employee
    {
        int empno;
        string empname, department;

        public Employee(int empno,string empname,string department)
        {
            this.empno = empno;
            this.empname = empname;
            this.department = department;
        }

        public Employee(int empno,string empname):this(empno,empname,"Department Not Assigned")
        { 
        
        }

        public override string ToString()
        {
            return "Employee Number:"+empno+" Employee Name:"+empname+" Department:"+department;
            //return base.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee(101,"Ajinkya"));
            empList.Add(new Employee(102,"Guru"));
            empList.Add(new Employee(103,"Tara","IT"));
            empList.Add(new Employee(104,"Ajuu","Technical"));

            foreach (Employee emp in empList)
            {
                Console.WriteLine(emp);
            }

            Console.ReadKey();
        }
    }
}
