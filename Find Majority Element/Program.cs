using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Majority_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> DictionarySet = new Dictionary<int,int>();

            int[] set = {3, 2, 3 };
          
            int MajorCount = set.Length / 2;
            bool Found = false;
            foreach (var item in set)
            {
                if (DictionarySet.ContainsKey(item))
                {
                    DictionarySet[item]++;
                    
                    if (DictionarySet[item] > MajorCount)
                    {
                        Found = true;
                        Console.WriteLine("Majority Element: " + item);
                        break;
                    }            
                }

                else 
                    DictionarySet[item] = 1;
            }

            if (!Found)
               Console.WriteLine("No Major Element :-(");
        }
    }
}
