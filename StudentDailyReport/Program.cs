using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            String yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            String courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            string needHelp = Console.ReadLine();
            bool needs = Convert.ToBoolean(needHelp);
            Console.WriteLine("Do you have any other feedback?");
            string  feedBack = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyNum = Convert.ToInt32(studyHours);
            Console.WriteLine("Your name is " + yourName + " and you're studying " + courseName + " and you're on page " + pageNum + " and when asked if you need help with anything, you replied " + needs + " and when asked for additional feedback, you said " + feedBack + " and you studied for " + studyNum + " hours. Press enter to continue");
            Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
