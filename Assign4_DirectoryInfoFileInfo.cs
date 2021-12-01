using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assign4_DirectoryInfoFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Director Information
            DirectoryInfo di = new DirectoryInfo("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding\\Sample");
            if (di.Exists)
            {
                Console.WriteLine(di.FullName);
                Console.WriteLine(di.CreationTime);
                Console.WriteLine(di.Parent);
                Console.WriteLine(di.LastWriteTime);


                //File Information
                FileInfo[] fi = di.GetFiles();
                Console.WriteLine();
                Console.WriteLine("The files in respective directory are as follows: ");
                Console.WriteLine("*********************************************************************************");
                foreach (FileInfo f in fi)
                {
                    Console.WriteLine(f.FullName);
                    Console.WriteLine(f.Extension);
                    Console.WriteLine(f.CreationTime);
                    Console.WriteLine(f.Length);
                    Console.WriteLine("*********************************************************************************");
                }
            }
            else
            {
                di.Create();
                Console.WriteLine("Directory created successfully");
            }

            Console.ReadKey();
        }
    }
}
