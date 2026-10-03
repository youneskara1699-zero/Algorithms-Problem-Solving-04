using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Skill_Matching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> CandidateSkills = new HashSet<string> { "C#", "SQL", "JavaScript" };
            HashSet<string> jobRequirements = new HashSet<string> { "C#", "JavaScript", "React" };

            CandidateSkills.IntersectWith(jobRequirements);

            Console.WriteLine("Matching Skills: " + string.Join(", ", CandidateSkills));

        }
    }
}
