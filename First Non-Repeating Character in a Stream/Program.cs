using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Non_Repeating_Character_in_a_Stream
{
    internal class Program
    {
        static void FindFirstNonRepeating(string stream)
        {
            Dictionary<char,int> countmap = new Dictionary<char,int>();
            Queue<char> queue = new Queue<char>();

            foreach (var ch in stream)
            {
                if (!countmap.ContainsKey(ch))
                    countmap[ch] = 0;


                countmap[ch]++;
                queue.Enqueue(ch);

                while (queue.Count > 0 && countmap[queue.Peek()] > 1)
                {
                    queue.Dequeue();
                }

                Console.WriteLine(queue.Count > 0 ? queue.Peek() : '-');

            }
           


        }
        static void Main(string[] args)
        {
            FindFirstNonRepeating("aabc");

        }
    }
}
