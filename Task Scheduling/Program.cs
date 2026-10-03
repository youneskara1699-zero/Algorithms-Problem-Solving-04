using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Scheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Task 1");
            queue.Enqueue("Task 2");
            queue.Enqueue("Task 3");
            queue.Enqueue("Task 4");

            Console.Write("Processed: ");
            while (queue.Count > 0) 
                Console.Write(" " + queue.Dequeue());



        }
    }
}
