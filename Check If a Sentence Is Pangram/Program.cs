using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_If_a_Sentence_Is_Pangram
{
    internal class Program
    {
        static bool IsSentencePangram(string Sentence)
        {
            Sentence = Sentence.ToLower();

            HashSet<char> set = new HashSet<char>(Sentence);

            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!set.Contains(c))
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            string Sentence = "The quick brown fox jumps over the lazy dog";

            Console.WriteLine(IsSentencePangram(Sentence));

        }
    }
}
