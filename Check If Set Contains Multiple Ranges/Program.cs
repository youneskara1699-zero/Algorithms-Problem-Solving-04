using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_If_Set_Contains_Multiple_Ranges
{
    internal class Program
    {
        static bool ContainsAllRanges(SortedSet<int> set, List<(int, int)> Ranges)
        {
            foreach (var (Low, High) in Ranges)
            {
                var range = set.GetViewBetween(Low, High);
                if (range.Count != (High - Low + 1))
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
            var Ranges = new List<(int, int)> { (1, 2), (4, 6) };

            Console.WriteLine(ContainsAllRanges(set, Ranges));


        }
    }
}
