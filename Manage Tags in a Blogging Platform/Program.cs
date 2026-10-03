using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Tags_in_a_Blogging_Platform
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> tags = new SortedSet<string>
            {
               "C#", "Programming", "Tutorial", "Python"
            };

            tags.Add("Java");
            tags.Add("C++");

            Console.WriteLine("All Tags:");
            foreach (var tag in tags)
            {
                Console.WriteLine(tag);
            }

        }
    }
}
