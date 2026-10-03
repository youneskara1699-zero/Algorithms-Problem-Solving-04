using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Clone_a_Queue_Without_Using_Extra_Space
{
    internal class Program
    {
      
        static Queue<int> CloneQueue(Queue<int> queue)
        {

            if (queue.Count == 0) return new Queue<int>();

          
            int Item = queue.Dequeue();
            Queue<int> Clonequeue = CloneQueue(queue);
            queue.Enqueue(Item);
            Clonequeue.Enqueue(Item);


            return Clonequeue;          
        }
       
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4 });
            Queue<int> clonedQueue = CloneQueue(queue);
            Console.WriteLine(string.Join(", ", clonedQueue)); 
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
