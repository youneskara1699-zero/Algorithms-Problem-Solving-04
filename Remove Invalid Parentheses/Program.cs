using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Invalid_Parentheses
{
    internal class Program
    {
        static string RemoveInvalidParentheses(string s)
        {
            Stack<int> stack = new Stack<int>();
            HashSet<int> InvalidIndices = new HashSet<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }

                else if (s[i] == ')')
                {
                    if (stack.Count == 0)
                        InvalidIndices.Add(i);
                    else
                        stack.Pop();
                }
            }

            while (stack.Count > 0)
            {
                InvalidIndices.Add(stack.Pop());
            }

            char [] result = new char[s.Length - InvalidIndices.Count];
            int index = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!InvalidIndices.Contains(i))
                {
                    result[index++] += s[i];
                }
            }


            return new string(result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RemoveInvalidParentheses("((())"));

        }
    }
}
