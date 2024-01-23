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
            int full_day = 8;
            int wage_per_day = wage_per_hour * full_day;
            Console.WriteLine(wage_per_day);
            Console.ReadLine();

        }
    }
}
