using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Decimal_to_Binary
{
    internal class Program
    {
        static string DecimalToBinary(int num)
        {
            Stack<int> stack = new Stack<int>();

            while (num > 0)
            {

                stack.Push(num % 2);

                num = num / 2;
            }

            return string.Join("", stack);
        }
        static void Main(string[] args)
        {
            int num = 25;
           

            Stack<int> stack = new Stack<int>();

            Console.WriteLine("Decimal Number: " + num);

          
            Console.WriteLine("Binary Number: " + DecimalToBinary(num));
        }
    }
}
