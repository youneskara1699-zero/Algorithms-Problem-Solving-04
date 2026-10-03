using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Periority_Stack
{
    internal class Program
    {
        class PriorityStack
        {
            private SortedDictionary<int, Stack<int>> stack =
                new SortedDictionary<int, Stack<int>>();

            public void Push(int priority, int value)
            {
                if (!stack.ContainsKey(priority))
                {
                    stack[priority] = new Stack<int>();
                }

                stack[priority].Push(value);
            }

            public int? Pop()
            {
                if (stack.Count == 0)
                    return null;

                // Smaller number = higher priority
                int highestPriority = stack.Keys.Min();

                int value = stack[highestPriority].Pop();

                if (stack[highestPriority].Count == 0)
                {
                    stack.Remove(highestPriority);
                }

                return value;
            }

            public void Display()
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(
                        item.Key + ": " +
                        string.Join(", ", item.Value)
                    );
                }
            }
        }
        static void Main(string[] args)
        {
            PriorityStack stack1 = new PriorityStack();

            stack1.Push(1, 3);
            stack1.Push(2, 4);
            stack1.Push(3, 5);
            stack1.Push(3, 6);

            stack1.Display();

            Console.WriteLine("Remove: " + stack1.Pop());

        }
    }
}
