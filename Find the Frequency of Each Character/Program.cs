using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Frequency_of_Each_Character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> CharFrequency = new Dictionary<char, int>();

            string text = "hello";

            foreach (var c in text)
            {
                if (CharFrequency.ContainsKey(c))
                    CharFrequency[c]++;
                else
                    CharFrequency[c] = 1;
            }

            Console.WriteLine("Word: " + text);
            Console.Write("{");

            foreach (var item in CharFrequency)
            {
                Console.Write(" " + item.Key + ": " + item.Value);
            }

            Console.Write(" }");

        }
    }
}
