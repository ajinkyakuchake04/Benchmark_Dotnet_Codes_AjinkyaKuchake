using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.printData();

            //Employee emp2 = new Employee(1002, "Guru", "Developer");
            Employee emp2 = new Employee("Guru", "Developer");
            emp2.printData();
            Console.ReadKey();
        }
    }
    class Employee
    {
        static int sno;
        int empno;
        string ename, designation;

        public Employee()
        {
            //empno = 1001;
            empno = ++sno;
            ename = "Ajinkya";
            designation = "Engineer";
        }

       /* public Employee(int eno, string enm, string desig)
        {
            empno = eno;
            ename = enm;
            designation = desig;
        }*/

        public Employee(string ename, string designation)
        {
            //this.empno = ++sno;
            empno = ++sno;
            this.ename = ename;
            this.designation = designation;
        }

        public void printData()
        {
            Console.WriteLine("Empno:"+empno+"Ename:"+ename+"Designation:"+designation);
        }

        ~Employee()
        {
            Console.WriteLine("Destructor called");
            Console.ReadKey();
        }
    }
}
