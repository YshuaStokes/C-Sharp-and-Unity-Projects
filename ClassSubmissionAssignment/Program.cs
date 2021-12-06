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
            Math math = new Math();

            
            

            Console.WriteLine("Enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            math.Divide(userInput);
            Console.WriteLine("3 * 2 = " + math.Multiply(3));
            Console.WriteLine("3 * 9 = " + math.Multiply(3, 9));

            Console.WriteLine("3 squared is " + StaticClass.StaticMultiply(int.Parse("3")));

            Console.ReadLine();

            //Console.WriteLine(StaticClass.myMethod(out int number));

            Console.WriteLine("Type some words please");
            string input = Console.ReadLine();
            string phrase = math.StringCounter(input, out int count);

            Console.WriteLine(phrase);

            int number = 5;
            StaticClass.myMethod(out number);
            Console.WriteLine(number);


            Console.ReadLine();



        }

        




    }
}
