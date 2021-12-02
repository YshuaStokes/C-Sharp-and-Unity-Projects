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
            Console.WriteLine("You chose the number " + userInput + "\n" + userInput + " + 5 is " + MyMethod1(userInput) + "\n" +
                userInput + " * 6 is " + MyMethod2(userInput) +"\n" +
                "7 - " + userInput + " is " + MyMethod3(userInput));
            Console.ReadLine();
            
        }

        public static int MyMethod1(int x)
        {
            return 5 + x;
        }

        public static int MyMethod2(int y)
        {
            return 6 * y;
        }

        public static int MyMethod3(int z)
        {
            return 7 - z;
        }

    }

    
}
