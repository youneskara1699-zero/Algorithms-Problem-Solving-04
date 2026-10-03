using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Balanced_Parentheses
{
    internal class Program
    {
        class BalancedParentheses
        {
            static bool IsBalanced(string input)
            {
                Stack<char> stack = new Stack<char>();


                foreach (char c in input)
                {
                    if (c == '(' || c == '{' || c == '[')
                    {
                        stack.Push(c); // Push opening brackets
                    }
                    else if (c == ')' || c == '}' || c == ']')
                    {
                        if (stack.Count == 0)
                            return false; // No matching opening bracket


                        char top = stack.Pop();


                        if ((c == ')' && top != '(') ||
                            (c == '}' && top != '{') ||
                            (c == ']' && top != '['))
                        {
                            return false; // Mismatched brackets
                        }
                    }
                }


                return stack.Count == 0; // Stack should be empty if balanced
            }


            static void Main()
            {
                string input = "({[]})";
                Console.WriteLine($"Is \"{input}\" balanced? {IsBalanced(input)}");


                input = "({[)]}";
                Console.WriteLine($"Is \"{input}\" balanced? {IsBalanced(input)}");


                Console.ReadKey();


            }
        }
    }
}
