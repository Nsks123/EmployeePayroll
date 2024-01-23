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
            Random rnd = new Random();
            int attendance = rnd.Next(0,2);
            if (attendance == 0)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }
            Console.ReadLine();
        }
    }
}
