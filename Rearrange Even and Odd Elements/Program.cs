using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rearrange_Even_and_Odd_Elements
{
    internal class Program
    {
        static Queue<int> RearrangeEvenOddQueueElements(Queue<int> Originalqueue)
        {
            Queue<int> Evenqueue = new Queue<int>();
            Queue<int> Oddqueue = new Queue<int>();
           

            while (Originalqueue.Count > 0)
            {
                  if (Originalqueue.Peek() % 2 == 0)
                     Evenqueue.Enqueue(Originalqueue.Dequeue());
                else
                    Oddqueue.Enqueue(Originalqueue.Dequeue());
            }

            Queue<int> Arrangedqueue = new Queue<int>(Evenqueue);

            while (Oddqueue.Count > 0)
            {
                  Arrangedqueue.Enqueue(Oddqueue.Dequeue());
            }

            return Arrangedqueue;
        }
        static void Main(string[] args)
        {
            Queue <int> Originalqueue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });

            Queue<int> Arrangedqueue = RearrangeEvenOddQueueElements(Originalqueue);

            Console.Write("Arrangedqueue Elements: " + string.Join(", ", Arrangedqueue));
          

           


            
        }
    }
}
