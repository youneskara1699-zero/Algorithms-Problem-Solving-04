using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Hashtable_to_Another_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable1 = new Hashtable
            {
              { "Name", "Alice" },
              { "Age", 25 }
            };

            Hashtable hashtable2 = new Hashtable(hashtable1);

            Console.WriteLine("Contents of copied Hashtable:");
            foreach (DictionaryEntry entry in hashtable2)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }


        }
    }
}
