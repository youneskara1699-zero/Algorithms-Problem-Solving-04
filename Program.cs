using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autocomplete_Suggestions_in_a_Search_Feature
{
    internal class Program
    {
        static IEnumerable<string> GetSuggestions(SortedSet<string> words, string prefix)
        {
            foreach (var word in words)
            {
                if (word.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                    yield return word;
            }
        }
        static void Main(string[] args)
        {
            SortedSet<string> words = new SortedSet<string>
            {
               "apple", "application", "appreciate", "banana", "band", "bandwidth", "cat", "cater"
            };

            Console.Write("Enter Prefix: ");
            var prefix = Console.ReadLine();

            var Suggestions = GetSuggestions(words, prefix);

            Console.WriteLine("Suggestions:");

            foreach (var item in Suggestions)
            {
                Console.Write(item + " ");
            }

        }
    }
}
