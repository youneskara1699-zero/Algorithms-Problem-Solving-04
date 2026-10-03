using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Find_Elements_Less_Than_a_Value
{
    internal class Program
    {
        static IEnumerable<int> ElementsLessThan(SortedSet<int> set, int value)
        {
            return set.GetViewBetween(int.MinValue, value - 1);
        }
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };

            int value = 4;

            Console.WriteLine(string.Join(", ", ElementsLessThan(set, value)));
        }
    }
}
