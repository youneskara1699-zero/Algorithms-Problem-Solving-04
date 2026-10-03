using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Middle_Element_in_a_Queue
{
    internal class Program
    {
        static int FindQueueMiddleElement(Queue<int> queue)
        {
            List<int> list = new List<int>(queue);

            return list[queue.Count/2];

        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 100, 200, 300, 500 });

            int Middle = FindQueueMiddleElement(queue);

            Console.WriteLine("Middle Element in queue: " + Middle);


        }
    }
}
