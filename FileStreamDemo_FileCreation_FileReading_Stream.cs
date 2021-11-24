using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//included

namespace FileStreamDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For file creation
            //try
            //{
            //    FileStream fs = new FileStream("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding\\Sample\\demo.dat", FileMode.Create, FileAccess.Write);
            //    for (int i = 0; i < 20; i++)
            //    {
            //        fs.WriteByte((byte)i);
            //    }
            //    fs.Flush();
            //    Console.WriteLine("Data Copied into the file");
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    //throw;
            //}

            //For file reading
            try
            {
                FileStream fs = new FileStream("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding\\Sample\\demo.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                for (int i = 0; i < 20; i++)
                {
                    fs.WriteByte((byte)i);
                }
                fs.Flush();
                
                Console.WriteLine("Reading the Data Copied into the file");
                fs.Position = 0;
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine((int)fs.ReadByte());
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }

            Console.ReadKey();
        }
    }
}
