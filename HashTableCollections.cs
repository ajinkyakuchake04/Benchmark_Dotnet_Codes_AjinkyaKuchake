using System;
using System.Collections;//Removed Generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashTable data stired in key-value pairs

            Hashtable etab = new Hashtable();
            etab.Add(1,"Ajinkya");
            etab.Add(2, "Guru");
            etab.Add(3, "Ajuu");
            etab.Add(4, "Tara");
            etab.Add(5, "Vaishnavi");
            etab.Add(6, "Vaishu");

            foreach (DictionaryEntry de in etab) //Dictionary entry is class which gives key value pairs
            {
                Console.WriteLine(de.Key+" "+de.Value);
            }

            //there are certain methods which can be accessed using
            //etab.
            
            Console.ReadKey();

        }
    }
}
