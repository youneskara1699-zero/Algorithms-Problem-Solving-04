using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace User_Survey_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitArray surveyResponses = new BitArray(5);

            surveyResponses[0] = true; 
            surveyResponses[1] = false;
            surveyResponses[2] = true;
            surveyResponses[3] = true; 
            surveyResponses[4] = false;

            for (int i = 0; i < surveyResponses.Length; i++)
            {
                Console.WriteLine($"User {i + 1}, Question {i + 1}: {surveyResponses[i]}");
            }


        }
    }
}
