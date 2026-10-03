using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Using_Two_Stacks
{
    internal class Program
    {
       class MyQueue
       {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();

            public void Enqueue(int x)
            {
                stack1.Push(x);
            }

            public int Dequeue()
            {
                if (stack2.Count == 0)
                {
                    while (stack1.Count > 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                }

                return stack2.Pop();
            }
            public bool IsEmpty()
            {
               return stack1.Count == 0 && stack2.Count == 0;
            }

        }
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

        }
    }
}
