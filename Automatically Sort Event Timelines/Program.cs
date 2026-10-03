using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatically_Sort_Event_Timelines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<DateTime> eventTimeline = new SortedSet<DateTime>
            {
              new DateTime(2024, 12, 25),
              new DateTime(2024, 11, 30),
              new DateTime(2025, 1, 1)
            };

            Console.WriteLine("Upcoming events:");
            foreach (var EventTime in eventTimeline)
            {
                Console.WriteLine(EventTime.ToShortDateString());
            }
        }
    }
}
