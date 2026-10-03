using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Binary_Numbers
{
    internal class Program
    {
        static void generateBinaryNumbers(int number)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");

            for (int i = 0; i < number; i++)
            {
                string binary = queue.Dequeue();
                Console.WriteLine(binary);
                queue.Enqueue(binary + "0");
                queue.Enqueue(binary + "1");
            }

        }
        static void Main(string[] args)
        {
            generateBinaryNumbers(5);

        }
    }
}
