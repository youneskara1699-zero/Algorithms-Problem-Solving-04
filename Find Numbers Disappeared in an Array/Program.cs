using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Numbers_Disappeared_in_an_Array
{
    internal class Program
    {
        static List<int> FindMissingNumbers(int[] nums)
        {
           HashSet<int> set = new HashSet<int>(nums);
           List<int> missingNumbers = new List<int>();

            int n = nums.Length;

            for (int i  = 1; i <= n; i ++)
            {
                if (! set.Contains(i))
                    missingNumbers.Add(i);
            }

            return missingNumbers;
        }
        static void Main(string[] args)
        {
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };

            Console.WriteLine("Missing Numbers are: " + string.Join(", ", FindMissingNumbers(nums)));
        }
    }
}
