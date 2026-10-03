using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_BitArray_from_an_Integer
{
    internal class Program
    {
        static BitArray IntToBitArray(int number)
        {
            return new BitArray(new[] { number});
        }
        static void Main(string[] args)
        {
            int number = 10; 
            BitArray bits = IntToBitArray(number);

            Console.Write("BitArray representation of " + number + ": ");
            bool LeadingZero = true;

            for (int i = bits.Length -1; i >= 0; i--)
            {
                if (bits[i])
                {
                    LeadingZero = false;
                }

                if (!LeadingZero)
                {
                    Console.Write(bits[i] ? "1" : "0");
                }
            }
               
            if (LeadingZero)
                Console.Write("0");
        }
    }
}
