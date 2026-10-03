using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Queue
{
    internal class Program
    {
        static bool IsPalindromeQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>(queue);

            foreach (var item in queue)
            {
                if (item != stack.Pop())
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 2, 1 });


            bool Result = IsPalindromeQueue(queue);

            if (Result)
                Console.WriteLine("Yes, Queue Is Palindrome :-)");
            else
                Console.WriteLine("No, Queue Is Not Palindrome :-(");

        }
    }
}
