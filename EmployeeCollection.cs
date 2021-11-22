using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCollection
{
    class Employee
    {
        int empno;
        string ename, department;

        public Employee(int eno, string enm, string dept)
        {
            empno = eno;
            ename = enm;
            department = dept;
        }

        public Employee(int eno, string enm):this(eno,enm,"Not Assigned")
        { 
                    
        }

        public override string ToString()
        {
            return "Emp No:"+empno+" Emp Name:"+ename+" Department: "+department;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee(1,"Ajinkya"));
            elist.Add(new Employee(2,"Guru"));
            elist.Add(new Employee(3,"Ajuu"));

            foreach (Employee  e in elist)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
