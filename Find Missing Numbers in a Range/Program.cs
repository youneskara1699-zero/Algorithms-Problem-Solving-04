using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Missing_Numbers_in_a_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> numbers = new SortedSet<int> { 1, 2, 4, 5, 7 };

            int n = numbers.Max;

            for (int i = 1; i <= n; i++)
            {
                if (!numbers.Contains(i))
                    Console.WriteLine(i);
            }
        }
    }
}
