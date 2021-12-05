using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Math integer = new Math();

            
            

            Console.WriteLine("Enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            integer.Divide(userInput);
            Console.WriteLine("3 * 2 = " + integer.Multiply(3));
            Console.WriteLine("3 * 9 = " + integer.Multiply(3, 9));

            Console.WriteLine("3 squared is " + StaticClass.StaticMultiply(int.Parse("3")));

            Console.ReadLine();
        }


        
    }
}
