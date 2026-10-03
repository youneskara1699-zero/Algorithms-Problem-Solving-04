using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_a_Queue
{
    internal class Program
    {
        static void RotateQueue(Queue<int> queue, int k)
        {

            for (int i = 0; i < k; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            Console.WriteLine("queue after rotation by " + k + " positions: " +string.Join(", ", queue));



        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int> (new[] { 1, 2, 3, 4, 5 });

            RotateQueue(queue, 2);




        }
    }
}
