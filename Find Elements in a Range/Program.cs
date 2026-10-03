using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Elements_in_a_Range
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
           SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };

           var Range = set.GetViewBetween(2, 4);

            Console.WriteLine("Range: " + string.Join(", ",Range));
        }
    }
}
