using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the answer to life, the universe, and everything?");
            int Answer = Convert.ToInt32(Console.ReadLine());
            bool AnswerGuessed = Answer == 42;


            //while (!AnswerGuessed)
            //{
            //    switch (Answer)
            //    {
            //        case 42:
            //            Console.WriteLine("42 is the answer to life, the universe and everything.");
            //            AnswerGuessed = true;
            //            break;

            //        default:
            //            Console.WriteLine("Wrong, try again");
            //            Console.WriteLine("What is the answer to life, the universe, and everything?");
            //            Answer = Convert.ToInt32(Console.ReadLine());
            //            break ;
            //    }
            //    Console.ReadLine();

            //}

            do
            {
                switch (Answer)
                {
                    case 42:
                        Console.WriteLine("42 is the answer to life, the universe and everything.");
                        AnswerGuessed = true;
                        break;

                    default:
                        Console.WriteLine("Wrong, try again");
                        Console.WriteLine("What is the answer to life, the universe, and everything?");
                        Answer = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                

            }
            while (!AnswerGuessed);

            Console.ReadLine();
        }
    }
}
