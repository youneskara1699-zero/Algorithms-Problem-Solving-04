using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rearrange_Queue_Alternately
{
    internal class Program
    {
        static Queue<int> RearrangeAlternately(Queue<int> queue)
        {
            Queue<int> result = new Queue<int>();
            List<int> list = new List<int>(queue);
            int n = queue.Count;

            for (int i = 0; i < n/2; i++)
            {
                result.Enqueue(list[i]);
                result.Enqueue(list[n-i-1]);
            }

            if (n % 2 != 0)
                result.Enqueue(list[n / 2]);

            return result;
        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6, 7 });
            Queue<int> rearrangedQueue = RearrangeAlternately(queue);
            Console.WriteLine(string.Join(", ", rearrangedQueue));

        }
    }
}
