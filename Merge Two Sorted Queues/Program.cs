using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Queues
{
    internal class Program
    {
        static Queue<int> MergeQueues(Queue<int> q1, Queue<int> q2)
        {
            Queue<int> Merged = new Queue<int>();

            while (q1.Count > 0 && q2.Count > 0)
            {
               if (q1.Peek() <= q2.Peek())
                  Merged.Enqueue(q1.Dequeue());

               else
                    Merged.Enqueue(q2.Dequeue());
            }

            while (q1.Count > 0 )
            {          
                 Merged.Enqueue(q1.Dequeue());
            }

            while (q2.Count > 0)
            {
                Merged.Enqueue(q2.Dequeue());
            }

            return Merged;
        }
        static void Main(string[] args)
        {
            Queue<int> q1 = new Queue<int>(new[] { 1, 3, 5 });
            Queue<int> q2 = new Queue<int>(new[] { 2, 4, 6 });
            Queue<int> mergedQueue = MergeQueues(q1, q2);
            Console.WriteLine(string.Join(", ", mergedQueue));

        }
    }
}
