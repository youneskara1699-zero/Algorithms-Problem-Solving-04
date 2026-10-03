using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Page_Request_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> Requestsqueue = new Queue<string>();

            Requestsqueue.Enqueue("Request 1");
            Requestsqueue.Enqueue("Request 2");
            Requestsqueue.Enqueue("Request 3");

            Console.WriteLine("Processing web requests:\n");

            while (Requestsqueue.Count > 0)
            {
                Console.WriteLine("Processed: " + Requestsqueue.Dequeue());

            }
        }
    }
}
