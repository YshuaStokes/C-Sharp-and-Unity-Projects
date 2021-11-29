using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main()
        {
            // 1. Array of Strings
            Console.WriteLine("Pick a number between 0-3");

            string[] stringArray = { "Eenie", "meanie", "miney", "moe" };

            string userInput1 = Console.ReadLine();

            int input1 = Convert.ToInt32(userInput1);
            Console.WriteLine(stringArray[input1] + "\nPress enter to continue");
            Console.ReadLine();



            // 2. Array of integers
            Console.WriteLine("Pick a number between 0 and 6");

            int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            string userInput = Console.ReadLine();

            int input = Convert.ToInt32(userInput);


            // 3. Error Messages.
            if (input > 6)
            {
                Console.WriteLine("You didn't follow instructions.");
                Console.ReadLine();
            }
            else if (input < 0)
            {
                Console.WriteLine("These instructions seem pretty easy to follow, and yet you didn't.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(numArray2[input]);
                Console.WriteLine("Select 0 for Kenobi's line, select 1 for Grievous' line.");


                // 4. List of Strings
                List<string> intList = new List<string>();
                intList.Add("Hello There!");
                intList.Add("General Kenobi!");

                string userInput2 = Console.ReadLine();
                int input2 = Convert.ToInt32(userInput2);

                Console.WriteLine(intList[input2]);
                Console.ReadLine();
            }


        }
    }
}