using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Elements_Greater_Than_a_Value
{
    internal class Program
    {
        static int CountElementsGreaterThan(SortedSet<int> set, int value)
        {
            return set.GetViewBetween(value + 1, int.MaxValue).Count; 
        }
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };

            int value = 3;
            int Count = CountElementsGreaterThan(set, value);

            Console.WriteLine(Count);
        }
    }
}
