using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Included

namespace FileIO_ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For Writing Data to a file
            //FileStream fs = null;
            //StreamWriter writer = null;
            //try
            //{
            //    fs = new FileStream("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding\\Sample\\ReadText.txt", FileMode.Create, FileAccess.Write);
            //    writer = new StreamWriter(fs);
            //    Console.WriteLine("Enter the data which needs to be stored in the file:");
            //    string data = "";
            //    while (data != null)
            //    {
            //        data = Console.ReadLine();
            //        writer.WriteLine(data);
            //    }
            //    writer.Flush();
            //    Console.WriteLine("Data copied into the file");
            //    Console.ReadKey();
            //}
            //catch (Exception io)
            //{
            //    Console.WriteLine("Exception :" + io.Message);
            //}
            //finally 
            //{
            //    writer.Close();
            //    fs.Close();
            //}


            //For Readinging Data from a file
            FileStream fs = null;
            StreamReader reader = null;
            try
            {
                fs = new FileStream("E:\\BENCHMARK IT SOLUTIONS\\Benchmark Assignments\\Normal Coding\\Sample\\ReadText.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fs);
                Console.WriteLine("The required data from the file is:");
                Console.WriteLine(reader.ReadToEnd());  
                Console.ReadKey();
            }
            catch (Exception io)
            {
                Console.WriteLine("Exception :" + io.Message);
            }
            finally
            {
                reader.Close();
                fs.Close();
            }

        }
    }
}
