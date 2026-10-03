using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_Browser_Back_Button
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack <string> history = new Stack<string>();

            history.Push("Page 1");
            history.Push("Page 2");
            history.Push("Page 3");

            Console.WriteLine("Back from: "+ history.Pop());
            Console.WriteLine("Current Page: " + history.Peek());

        }
    }
}
