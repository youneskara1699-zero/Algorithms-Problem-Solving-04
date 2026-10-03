using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate_Words_Between_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> TranslatorDictionary = new Dictionary<string, string>();

            TranslatorDictionary.Add("Hello", "Hola");
            TranslatorDictionary.Add("Goodbye", "Adiós");

            foreach (var item in TranslatorDictionary)
            {
                Console.WriteLine(item.Key + " in Spanish: " + item.Value);
            }
        }
    }
}
