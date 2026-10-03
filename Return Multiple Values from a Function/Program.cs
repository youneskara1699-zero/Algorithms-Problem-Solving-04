using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Return_Multiple_Values_from_a_Function
{
    internal class Program
    {
        static (string, int, int) StudentInfo(string Name, int Age, int Grade)
        {
           return (Name, Age, Grade);
        }
        static void Main(string[] args)
        {
           var Student = StudentInfo("John", 21, 19);
            Console.WriteLine("Name: " + Student.Item1);
            Console.WriteLine("Age: " + Student.Item2);
            Console.WriteLine("Grade: " + Student.Item3);
        }
    }
}
