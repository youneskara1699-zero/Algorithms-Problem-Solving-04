using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_System_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            int Current = 100, i = 1;

            while (i <= 5)
            {
                queue.Enqueue(Current + i);
                Console.WriteLine($"Ticket {Current + i} issued");
                i++;
            }

            Console.WriteLine("\nTicketing System Simulation Started...");

            while (queue.Count > 0)
            {
                Console.WriteLine("\nProcessing Ticket: " + queue.Dequeue());

                if (queue.Count != 0)
                    Console.WriteLine("Remaining Tickets: " + string.Join(", ", queue));

                else
                    Console.WriteLine("No more tickets in the queue.");
            }

            Console.WriteLine("\nTicketing System Simulation Ended.");
        }
    }
}
