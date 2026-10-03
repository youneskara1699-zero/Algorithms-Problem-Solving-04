using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_a_Priority_Queue
{
    internal class Program
    {
        public class PeriorityQueue
        {
            SortedDictionary<int, Queue<int>> queue = new SortedDictionary<int, Queue<int>>();
          
            public void Enqueue(int Value, int Periority)
            {
                if (!queue.ContainsKey(Periority))
                    queue[Periority] = new Queue<int>();

                queue[Periority].Enqueue(Value);
              
            }

            public int? Dequeue()
            {
                if (queue.Count == 0) return null;

                int HighestPeriority = queue.Keys.Max();
                int value = queue[HighestPeriority].Dequeue();

                if (queue[HighestPeriority].Count == 0)
                    queue.Remove(HighestPeriority);


                return value;
            }

        }
        static void Main(string[] args)
        {
            PeriorityQueue queue = new PeriorityQueue();

            queue.Enqueue(10, 1);
            queue.Enqueue(5, 3); 
            queue.Enqueue(20, 2);

            Console.WriteLine(queue.Dequeue());
        }
    }
}
