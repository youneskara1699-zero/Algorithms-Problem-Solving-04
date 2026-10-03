using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_and_Remove_Duplicates_from_a_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int> { 5, 5, 3, 8, 8, 5, 2, 3, 1 };

            SortedSet<int> sortedSet = new SortedSet<int>(numbersList);

            Console.WriteLine("\nUnique and sorted numbers:");
            foreach (var item in sortedSet)
            {
                Console.Write(item + " ");
            }

        }
    }
}
