using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Longest_Consecutive_Sequence
{
    internal class Program
    {
        static int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int longestStreak = 0;

            foreach (var num in set)
            {
                if (!set.Contains(num-1))
                {
                    int CurrentNum = num;
                    int CurrentStreak = 1;

                    while (set.Contains(CurrentNum +1))
                    {
                        CurrentNum++;
                        CurrentStreak++;
                    }

                    longestStreak = Math.Max(longestStreak, CurrentStreak);
                }
            }

            return longestStreak;
        }

        static void Main(string[] args)
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };
            Console.WriteLine(LongestConsecutive(nums));
        }
    }
}
