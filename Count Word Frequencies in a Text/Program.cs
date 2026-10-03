using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Word_Frequencies_in_a_Text
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            string text = "hello world hello universe";

            Dictionary<string, int> WordFrequencies = new Dictionary<string, int>();

            foreach (var word in text.Split(' '))
            {
                if (WordFrequencies.ContainsKey(word))
                    WordFrequencies[word]++;
                else
                    WordFrequencies[word] = 1;
            }

            foreach (var item in WordFrequencies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
