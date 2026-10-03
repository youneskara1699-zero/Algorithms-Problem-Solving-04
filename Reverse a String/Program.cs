using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reverse_a_String
{
    internal class Program
    {
        static string ReverseString(string Word)
        {
            Stack<char> stack = new Stack<char>();
            string ReverseWord = "";

            for (int i = 0; i < Word.Length; i++)
            {
                stack.Push(Word[i]);
            }

            while ( stack.Count > 0)
            {
                ReverseWord += stack.Pop();
              
            }

            return ReverseWord;
        }
        static void Main(string[] args)
        {
           string Word = "hello";

           Console.WriteLine("Original String: " + Word);
           Console.WriteLine("Reverse String: " + ReverseString(Word));



        }
    }
}
