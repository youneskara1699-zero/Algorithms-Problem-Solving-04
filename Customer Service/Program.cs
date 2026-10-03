using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Customer 1");
            queue.Enqueue("Customer 2");
            queue.Enqueue("Customer 3");
            queue.Enqueue("Customer 4");

            Console.WriteLine("Serving customers:\n");

            while (queue.Count > 0)
            {
              Console.WriteLine("Serving: " + queue.Dequeue() + "...");
            }
        }
    }
}
