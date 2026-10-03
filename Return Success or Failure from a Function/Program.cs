using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Success_or_Failure_from_a_Function
{
    internal class Program
    {
        static (string SuccessStatus, int StudentMark) StudentSucessResult(int StudentMark)
        {
            if (StudentMark >= 50)
                return ("Success :-)", StudentMark);
            else
                return ("Fail :-(", StudentMark);
        }
        static void Main(string[] args)
        {
            var Student = StudentSucessResult(76);
            Console.WriteLine("Student Mark: " + Student.StudentMark);
            Console.WriteLine("Success Status: " + Student.SuccessStatus);
        }
    }
}
