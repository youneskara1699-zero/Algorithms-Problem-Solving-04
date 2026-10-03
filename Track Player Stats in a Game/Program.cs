using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Track_Player_Stats_in_a_Game
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            var player1 = (Name: "Player1", Health: 100, Score: 2000);
            Console.WriteLine($"Name: {player1.Name}, Health: {player1.Health}, Score: {player1.Score}");

        }
    }
}
