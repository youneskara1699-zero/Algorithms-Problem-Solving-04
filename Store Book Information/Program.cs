using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Book_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string , (string Title, string Author)> BooksInfo = new Dictionary<string, (string, string)>
            {
                  {"978-3-16-148410-0",("The Great Gatsby","F. Scott Fitzgerald") },
                   {"978-1-61-729494-5",("C# in Depth"," Jon Skeet") },
            };

            foreach (var item in BooksInfo)
            {
                Console.WriteLine("ISBN: " + item.Key + ", Title: " + item.Value.Title + ", Author: " + item.Value.Author);
            }
        }
    }
}
