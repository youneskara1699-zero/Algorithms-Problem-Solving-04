using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_All_Elements_Not_in_a_Range
{
    internal class Program
    {
        static IEnumerable<int> ElementsNotInRange(SortedSet<int> set, int low, int high)
        {
            var range = set.GetViewBetween(low, high);
            SortedSet<int> result = new SortedSet<int>(set);
           result.ExceptWith(range);
            return result;
        }
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
            var result = ElementsNotInRange(set, 2, 4);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
