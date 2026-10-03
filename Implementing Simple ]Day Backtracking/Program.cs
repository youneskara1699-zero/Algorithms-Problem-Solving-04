using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Implementing_Simple_Day_Backtracking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Start -> Go to Gaz Station -> Go to Super Market -> Go To Work -> Go to Cafe -> Go Home.\n");

            Stack<string> DayStack = new Stack<string>(new[] { "Start", "Go to Gaz Station", "Go to Super Market", "Go To Work", "Go to Cafe", "Go Home" });

            Console.WriteLine("Backtracking...\n");

            while (DayStack.Count > 0)
            {
                Console.WriteLine("Back to: " + DayStack.Pop());
            }




        }
    }
}
