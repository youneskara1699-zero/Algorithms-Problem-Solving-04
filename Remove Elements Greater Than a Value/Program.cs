using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Elements_Greater_Than_a_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };

            int value = 3;
            set = set.GetViewBetween(int.MinValue, value);

            Console.WriteLine($"Set after removing elements greater than {value} : " + string.Join(", ", set));
        }
    }
}
