using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_palindrome_using_a_stack
{
    internal class Program
    {
        static bool IsPalindrome(string Word)
        {
          Stack<char> stack = new Stack<char>();

            foreach (var c in Word)
            {
                stack.Push(c);
            }

            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] != stack.Pop())
                    return false;
            }


            return stack.Count == 0;
        }
        static void Main(string[] args)
        {
            string Word = "hello", Word1 = "madam";
        
            Console.WriteLine("String: " + Word);
            Console.WriteLine("Is Palindrome ?? " + IsPalindrome(Word));

            Console.WriteLine("String: " + Word1);
            Console.WriteLine("Is Palindrome ?? " + IsPalindrome(Word1));

        }
    }
}
