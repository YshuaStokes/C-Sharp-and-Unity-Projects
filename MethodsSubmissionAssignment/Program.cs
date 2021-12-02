using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsSubmissionAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to do math operations on?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You chose the number " + userInput + "\n" + userInput + " + 5 is " + Math.MyMethod1(userInput) + "\n" +
                userInput + " * 6 is " + Math.MyMethod2(userInput) +"\n" +
                "7 - " + userInput + " is " + Math.MyMethod3(userInput));
            Console.ReadLine();
            
        }

       

    }

    
}
