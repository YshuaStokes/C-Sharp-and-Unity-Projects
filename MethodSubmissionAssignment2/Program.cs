using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math myMath = new Math();

            Console.WriteLine("Input a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input another number (optional)");

            try
            {
               
                int userInput2 = Convert.ToInt32(Console.ReadLine());
                myMath.MyMethod(userInput, userInput2);
            } catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                myMath.MyMethod(userInput);
            }

            

            Console.ReadLine();
            
            
            
        }
    }
}
