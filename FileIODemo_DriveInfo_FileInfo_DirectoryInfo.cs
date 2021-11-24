using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Include while using IO

namespace FileIODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo dri = new DriveInfo("E:\\");
            Console.WriteLine(dri.Name);
            Console.WriteLine(dri.DriveFormat);
            Console.WriteLine(dri.AvailableFreeSpace);
            Console.WriteLine(dri.IsReady);

            Console.WriteLine();
            Console.WriteLine(Path.GetFileName("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding"));
            Console.WriteLine(Path.GetExtension("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding"));
            Console.WriteLine(Path.GetDirectoryName("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding"));

            //DirectoryInfo di = new DirectoryInfo("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding\\Sample");
            //if (di.Exists)
            //{
            //    Console.WriteLine(di.FullName);
            //    Console.WriteLine(di.CreationTime);
            //    Console.WriteLine(di.Parent);
            //    Console.WriteLine(di.LastWriteTime);

            //    FileInfo[] fi = di.GetFiles();
            //    Console.WriteLine();
            //    Console.WriteLine("The files in respective directory are as follows: ");
            //    Console.WriteLine("*********************************************************************************");
            //    foreach (FileInfo f in fi)
            //    {
            //        Console.WriteLine(f.FullName);
            //        Console.WriteLine(f.Extension);
            //        Console.WriteLine(f.CreationTime);
            //        Console.WriteLine(f.Length);
            //        Console.WriteLine("*********************************************************************************");
            //    }
            //}
            //else
            //{
            //    di.Create();
            //    Console.WriteLine("Directory created successfully");
            //}

            Console.ReadKey();
        }
    }
}
