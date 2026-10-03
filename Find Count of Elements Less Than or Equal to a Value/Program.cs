using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Count_of_Elements_Less_Than_or_Equal_to_a_Value
{
    internal class Program
    {
        static int CountLessThanOrEqual(SortedSet<int> set, int value)
        {
            return set.GetViewBetween(int.MinValue, value).Count;
        }
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(CountLessThanOrEqual(set, 3));
        }
    }
}
