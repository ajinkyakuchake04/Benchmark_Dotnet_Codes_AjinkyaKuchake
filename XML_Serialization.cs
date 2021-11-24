using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;//Included for xml Serialization
using System.IO;//Included

namespace Serialization_XML
{
    [Serializable]
    public class Employee //Class must be public
    {
        public int empno;   //Members must be public
        public string ename;

        //[NonSerialized] //For not serializing use this attribute
        public int salary;


        public Employee()
        { 
        
        }
        public Employee(int eno, string enm, int sal)
        {
            empno = eno;
            ename = enm;
            salary = sal;
        }
        public override string ToString()
        { 
            return "Employee Number:"+empno+" Employee Name:"+ename+" Employee Salary" + salary;
        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Serialization
            FileStream fs = new FileStream("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding\\Sample\\Employee.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Employee emp = new Employee(111, "Ajinkya Kuchake", 100000);
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            serializer.Serialize(fs, emp);
            Console.WriteLine("The Employee object is Serialized");
            Console.ReadKey();

            ////DeSerialization
            //FileStream fs = new FileStream("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding\\Sample\\Employee.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            //Employee emp = (Employee)serializer.Deserialize(fs);
            //Console.ReadKey();


        }
    }
}
