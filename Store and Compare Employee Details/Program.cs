using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Store_and_Compare_Employee_Details
{
    internal class Program
    {
        static (string Name, int Salary) EmployeeInfo(string Name, int Salary)
        {
            return (Name, Salary);
        }
        static void Main(string[] args)
        {
            var Employee1 = EmployeeInfo("John", 4000);
            var Employee2 = EmployeeInfo("James", 3000);

            Console.WriteLine($"{Employee1.Name} has {(Employee1.Salary > Employee2.Salary? "Higher" : "Lower")} salary than {Employee2.Name} .");
        }
    }
}
