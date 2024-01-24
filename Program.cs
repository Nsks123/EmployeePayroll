using System;

namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            while (true) 
            {
                int attendance = rnd.Next(0, 2);

                if (attendance == 0)
                {
                    Console.WriteLine("Present");

                    int wagePerHour = 20;
                    int fullDay = 8;
                    int wagePerDay = wagePerHour * fullDay;
                    Console.WriteLine($"Wage for a full day: {wagePerDay}");
                }
                else
                {
                    Console.WriteLine("Absent");

                    int wagePerHour = 20;
                    int partTime = 4;
                    int wagePerDay = wagePerHour * partTime;
                    Console.WriteLine($"Wage for part-time: {wagePerDay}");
                }

                Console.ReadLine();
            }
        }
    }
}
