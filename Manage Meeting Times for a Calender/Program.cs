using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Meeting_Times_for_a_Calender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<TimeSpan> MeetingTimes = new SortedSet<TimeSpan>
            {
               new TimeSpan(14, 0,0),
               new TimeSpan(9, 30, 0), 
               new TimeSpan(11, 0, 0)  
            };

            Console.WriteLine("Today's meetings (sorted):");

            foreach (var time in MeetingTimes)
            {
                Console.WriteLine(time);
            }

        }
    }
}
