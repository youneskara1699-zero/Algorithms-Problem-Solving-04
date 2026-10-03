using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Light_Control_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitArray Lights = new BitArray(8, false);

            Lights[0] = true;
            Lights[5] = true;

            Console.WriteLine($"Light 1: {Lights[0]}, Light 6: {Lights[5]}");

            Lights.SetAll(false);

            Console.WriteLine($"Light 1 after reset: {Lights[0]}");

        }
    }
}
