using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Words_That_Can_Be_Typed_Using_One_Row_of_Keyboard
{
    internal class Program
    {
        static string[] FindWords(string[] words)
        {
            string[] rows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            Dictionary<char,int> CharRows = new Dictionary<char,int>();

            for (int i = 0; i < rows.Length; i++)
            {
                foreach (var c in rows[i])
                {
                    CharRows[c] = i;
                }
            }

            List<string> result = new List<string>();

            foreach (var word in words)
            {
                int row = CharRows[char.ToLower(word[0])]; 
                bool IsValid = true;

                foreach (var c in word)
                {
                    if (CharRows[char.ToLower(c)] != row)
                    {
                        IsValid = false;
                        break;
                    }
                }

                if (IsValid)
                    result.Add(word);

            }

            return result.ToArray();

        }
        static void Main(string[] args)
        {
            string[] words = { "Hello", "Alaska", "Dad", "Peace" };
            Console.WriteLine(string.Join(", ", FindWords(words)));
        }
    }
}
