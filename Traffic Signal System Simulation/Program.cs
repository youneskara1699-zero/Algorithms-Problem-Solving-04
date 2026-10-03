using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Signal_System_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Car 1");
            queue.Enqueue("Truck 1");
            queue.Enqueue("Bike 1");
            queue.Enqueue("Bus 1");

            Console.WriteLine("Traffic Signal Simulation Started...");

            while (queue.Count > 0)
            {
                Console.WriteLine("\n" + queue.Dequeue() + " has passed the signal.");

                if (queue.Count != 0)
                    Console.WriteLine("Vehicles waiting: " + string.Join(", ", queue));

                else
                    Console.WriteLine("No vehicles waiting.");
            }

            Console.WriteLine("\nTraffic Signal Simulation Ended.");


        }
    }
}
