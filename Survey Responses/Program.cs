using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey_Responses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] surveyResponses = new string[3][];
            surveyResponses[0] = new string[] { "Yes", "No" }; 
            surveyResponses[1] = new string[] { "No", "Yes", "Yes" }; 
            surveyResponses[2] = new string[] { "Yes" }; 


            Console.WriteLine("Survey Responses:");
            for (int i = 0; i < surveyResponses.Length; i++)
            {
                Console.Write($"Respondent {i + 1}: ");
                foreach (string response in surveyResponses[i])
                {
                    Console.Write(response + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
