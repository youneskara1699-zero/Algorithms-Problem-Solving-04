using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Seat_Reservations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[][] FlightSeats = new bool[2][];
            FlightSeats[0] = new bool[] { true, false, true };
            FlightSeats[1] = new bool[] { false, false, true, true };

            Console.WriteLine("Seat Availability:");

            for (int i = 0; i < FlightSeats.Length; i++)
            {
                Console.Write($"Flight  {i+ 1} : ");

                foreach (var seat in FlightSeats[i])
                {
                    Console.Write(seat ? "Available " : "Occupied " );
                }
                Console.WriteLine();
            }

        }
    }
}
