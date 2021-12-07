using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week.");
            string userInput = Console.ReadLine();
            
            
            try
            {
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);
                Console.WriteLine("Today is " + day + ".");
                Console.ReadLine();
            } catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week. Remember to use capital letters");
                Console.ReadLine();
            }
            
            
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
    }
}
