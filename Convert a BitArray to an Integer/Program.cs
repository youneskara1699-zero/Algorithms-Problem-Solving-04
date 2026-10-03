using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_a_BitArray_to_an_Integer
{
    internal class Program
    {
        static int BitArrayToInt(BitArray bits)
        {
            int Result = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                Result += (1<<i);
            }

            return Result;
        }
        static void Main(string[] args)
        {
            BitArray bits = new BitArray(new bool[] { true, false, true });

            int number = BitArrayToInt(bits);

            Console.WriteLine("Integer value of BitArray: " + number);
        }
    }
}
