using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_Queue
{
    internal class Program
    {
        static Queue<int> ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (stack.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
            return queue;
        }

        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Queue<int> Reversequeue = ReverseQueue(queue);

            Console.WriteLine("After Reversing the queue: ");
            foreach (var item in Reversequeue)
            {
                Console.Write(item + " ");
            } 

        }
    }
}
