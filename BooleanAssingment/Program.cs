using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanAssingment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int Age = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            string dui = Console.ReadLine();
            bool DUI = Convert.ToBoolean(dui);
            Console.WriteLine("How many speeding tickets to you have?");
            string speeding = Console.ReadLine();
            int Tickets = Convert.ToInt32(speeding);

            //Boolean Logic
            bool ageBool = (Age > 15);
            bool ticketsBool = (Tickets <= 3);
            bool NoDui = (DUI == false);
            bool approved = (ageBool && ticketsBool && NoDui);
            Console.WriteLine("Approved: " + approved);

            Console.ReadLine();
        }
    }
}
