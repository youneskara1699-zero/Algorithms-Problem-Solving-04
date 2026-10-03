using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Reserved_Seats_in_a_Theater
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedSet<int> reservedSeats = new SortedSet<int> { 10, 20, 30 };


            reservedSeats.Add(25);


            if (!reservedSeats.Add(10))
            {
                Console.WriteLine("\nSeat 10 is already reserved!\n");
            }


            Console.WriteLine("Reserved Seats:");
            foreach (var seat in reservedSeats)
            {
                Console.WriteLine("Seat " + seat);
            }
        }
    }
}
