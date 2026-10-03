using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_for_Duplicate_Entries_in_Real_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> DataEntries = new HashSet<string>();

            string[] entries = { "A", "B", "C", "A", "B" };

            foreach (var entry in entries)
            {
                if (!DataEntries.Add(entry))
                    Console.WriteLine("Duplicated entry detected: " + entry);
            }

        }
    }
}
