using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            
            Console.WriteLine(dateTime + "\nPlease enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userInput + " hours from now it will be " + dateTime.AddHours(userInput));
            Console.ReadLine();
            
            
        }
    }
}
