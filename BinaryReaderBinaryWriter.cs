using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Included

namespace BinaryReaderBinaryWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Binary Writer
            //FileStream fs = null;
            //BinaryWriter writer = null;


            //try
            //{
            //    fs = new FileStream("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding\\Sample\\test", FileMode.Create, FileAccess.Write);
            //    writer = new BinaryWriter(fs);
            //    Console.WriteLine("Enter Roll Number: ");
            //    int rollno = Convert.ToInt32(Console.ReadLine());
            //    writer.Write(rollno);

            //    Console.WriteLine("Enter Name: ");
            //    string name = Console.ReadLine();
            //    writer.Write(name);

            //    Console.WriteLine("Enter Course: ");
            //    string course = Console.ReadLine();
            //    writer.Write(course);

            //    writer.Flush();

            //    Console.WriteLine("Data written to file");
            //    Console.ReadKey();
            //}
            //catch (IOException io)
            //{
            //    Console.WriteLine(io.Message);
            //    //throw;
            //}
            //finally
            //{
            //    fs.Close();
            //    writer.Close();
            //}

            //Binary Reader
            FileStream fs = null;
            BinaryReader reader = null;

            try
            {
                fs = new FileStream("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding\\Sample\\test", FileMode.Open, FileAccess.Read);
                fs.Position = 0;
                reader = new BinaryReader(fs);
                Console.WriteLine("Roll No: "+reader.ReadInt32());
                Console.WriteLine("Name: " + reader.ReadString());
                Console.WriteLine("Course: " + reader.ReadString());
                Console.ReadKey();
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
                //throw;
            }

            finally
            {
                fs.Close();
                reader.Close();
            }
        }
    }
}
