using System;
using System.Collections;//For Non-Generic Collection
using System.Collections.Generic;//For Generic Collection
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_StudentKeyValueGenericNongeneric
{
    class Program
    {
        static void Main(string[] args)
        {

            //Hash Table is Non-generic (Key,Value)
            Console.WriteLine("Using Non-Generic Hash Table:");
            Hashtable etab = new Hashtable();
            etab.Add(1, "Ajinkya");
            etab.Add(2, "Guru");
            etab.Add(3, "Ajuu");
            etab.Add(4, "Tara");
           
            foreach (DictionaryEntry de in etab) //Dictionary entry is class which gives key value pairs
            {
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            }

            Console.WriteLine();

            //Dictionary is Generic (Key,Value)
            Dictionary<int, string> rollName = new Dictionary<int, string>();
            Console.WriteLine("Using Generic Dictionary:");
            rollName.Add(101, "ABC"); //adding a key/value using the Add() method
            rollName.Add(201, "XYZ");
            rollName.Add(301, "LMN");
            rollName.Add(401, "PQR");


            foreach (KeyValuePair<int, string> kv in rollName)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kv.Key, kv.Value);
            }

            Console.ReadKey();
        }
    }
}
