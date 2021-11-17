using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person 1 salary calculation
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1, what is your hourly rate?");
            string p1HourlyRate = Console.ReadLine();
            int p1hourRate = Convert.ToInt32(p1HourlyRate);
            Console.WriteLine("Person 1, how many hours did you work this week?");
            string p1WeeklyHours = Console.ReadLine();
            int p1hoursWorked = Convert.ToInt32(p1WeeklyHours);
            int p1annualSalary = p1hoursWorked * p1hourRate * 52;
            //Person 2 salary
            Console.WriteLine("Person 2, what is your hourly rate?");
            string p2HourlyRate = Console.ReadLine();
            int p2hourRate = Convert.ToInt32(p2HourlyRate);
            Console.WriteLine("Person 2, how many hours did you work this week?");
            string p2WeeklyHours = Console.ReadLine();
            int p2hoursWorked = Convert.ToInt32(p2WeeklyHours);
            int p2annualSalary = p2hoursWorked * p2hourRate * 52;
            bool salaryComparison = p1annualSalary > p2annualSalary;
            Console.WriteLine("Annual salary of Person 1: " + p1annualSalary + " dollars per year. Annual salary of Person 2: " + p2annualSalary + " dollars per year");
            Console.WriteLine("Does person 1 make more money than Person 2? " + salaryComparison);
            Console.ReadLine();
        }
    }
}
 