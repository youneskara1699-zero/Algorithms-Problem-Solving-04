using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interleave_Queue_Elements
{
    internal class Program
    {
        static void InterleaveQueue(Queue<int> queue)
        {
           int HalfSize = queue.Count / 2;
           Stack<int> stack = new Stack<int>();

            for (int i = 0; i < HalfSize; i++)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            for (int i = 0; i < HalfSize; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            for (int i = 0; i < HalfSize; i++)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
                queue.Enqueue(queue.Dequeue());
            }

        }


        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });
            InterleaveQueue(queue);
            Console.WriteLine(string.Join(", ", queue));



            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Enqueue(6);

            //Queue<int> Hqueue1 = new Queue<int>();

            //for (int i = 1; i <= queue.Count/2; i++)
            //{
            //    Hqueue1.Enqueue(i);
            //}


            //Queue<int> Hqueue2 = new Queue<int>();

            //for (int i = (queue.Count/2)+1; i <= queue.Count; i++)
            //{
            //    Hqueue2.Enqueue(i);
            //}

            //Queue<int> Interleavequeue = new Queue<int>();

            //while (Hqueue1.Count != 0 && Hqueue2.Count != 0)
            //{
            //    Interleavequeue.Enqueue(Hqueue1.Peek());
            //    Hqueue1.Dequeue();

            //    Interleavequeue.Enqueue(Hqueue2.Peek());
            //    Hqueue2.Dequeue();
            //}

            //Console.Write(string.Join(", ", Interleavequeue));
        }
    }
}
