using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_Tasks
{
    internal class Program
    {
        enum endays {Sunday = 1, Monday = 2, thuesday = 3, Wednesday = 4, Thursday = 5, Friday = 6, Saturday = 7 };
        static void Main(string[] args)
        {
            BitArray schedule = new BitArray(7, true);

            schedule[0] = false;
            schedule[4] = false;

            Console.Write("Free Days: ");
            for (int i = 0; i < schedule.Length; i++)
            {
                if (!schedule[i])
                    Console.Write($"{ (endays)i+1}  ");
            }

        }
    }
}
