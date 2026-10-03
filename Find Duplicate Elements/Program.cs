using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Duplicate_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> set = new Dictionary<int,int>();
            int[] nums = { 1, 2, 3, 4, 2, 5, 6, 1 };

            foreach (var num in nums)
            {
                if (!set.ContainsKey(num))
                    set[num] = 0;

                set[num]++;
            }

            Console.Write("Duplicated Elements: ");

            foreach (var item in set)
            {
                if (item.Value > 1)
                    Console.Write(item.Key + " ");  
            }

        }
    }
}
