using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Time_Leaderboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> leaderboard = new SortedList<string, int>
            {
                 { "Alice", 1200 },
                 { "Charlie", 1500 },
                 { "Bob", 1300 }
            };

            foreach (var player in leaderboard)
            {
                Console.WriteLine($"Player: {player.Key}, Score: {player.Value}");
            }
        }
    }
}
