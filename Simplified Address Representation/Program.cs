using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplified_Address_Representation
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            var address = (Street: "123 Main St", City: "Springfield", State: "IL", Zip: "62704");
            Console.WriteLine($"Address: {address.Street}, {address.City}, {address.State}, {address.Zip}");

        }
    }
}
