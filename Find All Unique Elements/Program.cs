using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_All_Unique_Elements
{
    internal class Program
    {
        static List<int> UniqueElements(int[] nums)
        {
            Dictionary<int,int> set = new Dictionary<int,int>();
            List<int> uniques = new List<int>();

            foreach (var num in nums)
            {
                if (!set.ContainsKey(num))
                    set[num] = 0;            
                
                set[num]++;
            }

            foreach (var item in set)
            {
                if (item.Value == 1)
                    uniques.Add(item.Key);
            }

            return uniques;
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 2, 3, 4, 5, 3 };

            Console.Write("Unique Elements: " + string.Join(", ", UniqueElements(nums)));


        }
    }
}
