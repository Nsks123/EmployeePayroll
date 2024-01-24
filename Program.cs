using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wage_per_hour = 20;
            int Part_Time = 4;
            int wage_per_day = wage_per_hour * Part_Time;
            Console.WriteLine(wage_per_day);
            Console.ReadLine();

        }
    }
}
