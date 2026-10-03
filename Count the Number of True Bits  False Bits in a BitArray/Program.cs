using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Number_of_True_Bits__False_Bits_in_a_BitArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitArray bits = new BitArray(new bool[] { false, true, true, false, false, false });

            int trueBits = 0, falseBits = 0;

            foreach (bool bit in bits)
            {
                if (bit) trueBits++;

                else falseBits++;
            }

            Console.WriteLine("True Bits: " + trueBits);
            Console.WriteLine("False Bits: " + falseBits);

        }
    }
}
