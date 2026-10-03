using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perform_Bitwise_AND_Between_Two_BitArrays
{
    internal class Program
    {
        static BitArray PerformAND(BitArray bit1, BitArray bit2)
        {
            if (bit1.Length != bit2.Length)
               throw new ArgumentException("BitArrays must have the same length!");

            return bit1.And(bit2);

        }
        static void Main(string[] args)
        {
            BitArray bits1 = new BitArray(new bool[] { true, false, true });
            BitArray bits2 = new BitArray(new bool[] { true, true, false });
  
            var Result = PerformAND(bits1, bits2);

            foreach (bool item in Result)
            {
                Console.Write(item + " ");
            }

        }
    }
}
