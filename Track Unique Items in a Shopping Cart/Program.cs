using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Track_Unique_Items_in_a_Shopping_Cart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> shoppingCart = new SortedSet<string>
            {
              "Apple",
              "Banana",
              "Orange",
              "Apple"
            };

            Console.WriteLine("Shopping cart items (sorted):");

            foreach (var item in shoppingCart)
            {
                Console.Write(item + " ");
            }


        }
    }
}
