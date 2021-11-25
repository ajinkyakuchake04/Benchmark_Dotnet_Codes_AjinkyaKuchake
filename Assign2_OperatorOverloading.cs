using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2_OperatorOverloading
{
    class Student
    {
        double marks;
        string name;

        public Student()
        { 
        
        }
        public Student(string name,double marks)
        {
            this.marks = marks;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine("Student Name:"+name+"  Marks:"+marks);
        }

        public static Student operator +(Student a, Student b)
        {
            Student s3 = new Student();
            s3.name = a.name + b.name;
            s3.marks = a.marks + b.marks;

            return s3;
        }

        public static Student operator -(Student a, Student b)
        {
            Student s3 = new Student();
            s3.name = "Anonymous";
            s3.marks = a.marks - b.marks;

            return s3;
        }

        public static Student operator *(Student a, Student b)
        {
            Student s3 = new Student();
            s3.name = "Anonymous";
            s3.marks = a.marks * b.marks;

            return s3;
        }

        public static Student operator /(Student a, Student b)
        {
            Student s3 = new Student();
            s3.name = "Anonymous";
            s3.marks = a.marks / b.marks;

            return s3;
        }

        public static bool operator ==(Student a, Student b)
        {
            if (a.marks == b.marks)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Student a, Student b)
        {
            if (a.marks != b.marks)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ajinkya",100);
            Student s2 = new Student("Guru",90);
            Student s3 = new Student();

            s1.display();
            s2.display();

            Console.WriteLine();
            Console.WriteLine("The results of operator overloading are as follows:");
            Console.WriteLine();
            Console.WriteLine("+ operator overloading");
            s3 = s1 + s2;
            s3.display();

            Console.WriteLine();
            Console.WriteLine("- operator overloading");
            s3 = s1 - s2;
            s3.display();

            Console.WriteLine();
            Console.WriteLine("* operator overloading");
            s3 = s1 * s2;
            s3.display();

            Console.WriteLine();
            Console.WriteLine("/ operator overloading");
            s3 = s1 / s2;
            s3.display();

            Console.WriteLine();
            Console.WriteLine("== operator overloading");
            if (s1 == s2)
            {
                Console.WriteLine("Both students have same marks");
            }
            else
            {
                Console.WriteLine("Both students do not have same marks");
            }

            Console.WriteLine();
            Console.WriteLine("!= operator overloading");
            if (s1 != s2)
            {
                Console.WriteLine("Both students do not have same marks");
            }
            else
            {
                Console.WriteLine("Both students have same marks");
            }

            Console.ReadLine();
        }
    }
}
