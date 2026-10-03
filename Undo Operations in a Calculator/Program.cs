using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undo_Operations_in_a_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> calculatorStack = new Stack<int>();
            calculatorStack.Push(10);
            calculatorStack.Push(20);
            calculatorStack.Push(30);


            Console.WriteLine("Undo: " + calculatorStack.Pop());
            Console.WriteLine("Current Result: " + calculatorStack.Peek());


        }
    }
}
