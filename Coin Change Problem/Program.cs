using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Change_Problem
{
    internal class Program
    {
        static List<int> MinCoins(List<int> coins, int Amount)
        {
            coins.Sort ((a, b) => b.CompareTo(a));

            List<int> result = new List<int>();

            foreach (var coin in coins)
            {
                while (Amount >= coin)
                {
                    Amount -= coin;
                    result.Add(coin);
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            List<int> coins = new List<int> { 1, 5, 10, 20, 50, 100 };

            int Amount = 33;

            var result = MinCoins(coins, Amount);

            Console.WriteLine("Total coins : " + string.Join(", ",result));
            Console.WriteLine("Total papers: " + result.Count);
            

        }
    }
}
