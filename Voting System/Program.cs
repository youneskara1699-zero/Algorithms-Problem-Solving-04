using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitArray votes = new BitArray(new bool[] { true, false, true, true, false, false, true, true });


            int yesVotes = 0;
            foreach (bool vote in votes)
            {
                if (vote) yesVotes++;
            }

            Console.WriteLine($"Yes Votes: {yesVotes} out of 8 ");

        }
    }
}
