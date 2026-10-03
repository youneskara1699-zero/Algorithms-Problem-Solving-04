using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Missing_Number_in_an_Array
{
    internal class Program
    {
        static int FindMissingNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);


            int n = nums.Length;

            for (int i = 0; i <= n; i++)
            {
                if (!set.Contains(i))
                    return i;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] nums = { 3, 0,1 };
          
            int MissingNumber = FindMissingNumber(nums);

            if (MissingNumber != -1)
                Console.WriteLine("Missing Number: " + MissingNumber);

            else
                Console.WriteLine("No Missing Number ");

        }
    }
}
