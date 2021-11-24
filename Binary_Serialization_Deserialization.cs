using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SerializationBinary
{
    internal class Program
    {
        [Serializable]//For Serialization It is an attribute to convey that the class can be serialized. Use squared brackets
        class Employee
        {
            int empno;

            [NonSerialized]//For not serializing this particular variable
            string ename;

            public Employee()
            { 
            
            }
            public Employee(int eno, string enm)
            {
                empno = eno;
                ename = enm;
            }

            public override string ToString()
            {
                return "Employee Number:"+empno+" Employee Name:"+ename;
            }
        }

        static void Main(string[] args)
        {

            //For Serialization
            //Employee emp = new Employee(111,"Ajinkya");

            //FileStream fs = new FileStream("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding\\Sample\\Employee.dat", FileMode.Create,FileAccess.Write);
            //BinaryFormatter formatter = new BinaryFormatter();

            //formatter.Serialize(fs,emp);
            //Console.WriteLine("The required object is serialized");

            //Console.ReadKey();


            //For DeSerialization
            //Employee emp = new Employee(111, "Ajinkya");

            //FileStream fs = new FileStream("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding\\Sample\\Employee.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //BinaryFormatter formatter = new BinaryFormatter();

            //Employee obj = (Employee)formatter.Deserialize(fs);
            //Console.WriteLine(obj);

            //Console.ReadKey();

            //For Non-Serialized
            Employee emp = new Employee(111, "Ajinkya");

            FileStream fs = new FileStream("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding\\Sample\\Employee.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(fs, emp);
            Employee obj = (Employee)formatter.Deserialize(fs);
            Console.WriteLine(obj);

            Console.ReadKey();
        }
    }
}
