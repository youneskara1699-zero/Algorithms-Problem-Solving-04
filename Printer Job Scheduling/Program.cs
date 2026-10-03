using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer_Job_Scheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> printerQueue = new Queue<string>();

            printerQueue.Enqueue("Document1");
            printerQueue.Enqueue("Document2");
            printerQueue.Enqueue("Document3");

            Console.WriteLine("Current Job: " + printerQueue.Dequeue());
            Console.WriteLine("Next Job: " + printerQueue.Peek());

        }
    }
}
