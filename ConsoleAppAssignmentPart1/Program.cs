using System;
using System.Collections.Generic;


namespace ConsoleAppAssignmentPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //CONSOLE APP ASSIGNMENT PART ONE

            string[] names = { "jesse", "erik", "adam", "daniel", };

            Console.WriteLine("input some text");

            string userinput = Console.ReadLine();

            foreach (string name in names)
            {
                Console.WriteLine(name + " " + userinput);
            }
            Console.WriteLine("press enter to continue");
            Console.ReadLine();

            foreach (string name in names)
            {
                Console.WriteLine(name + "\n");
            }

            Console.WriteLine("press enter to continue");
            Console.ReadLine();

            //end console app assignment part one

            //console app assignment part two

            for (int i = 0; i < 5; i++) //changed "i--" to "i++" to fix the infinite loop
            {
                Console.WriteLine("this should only be written 5 times", i);
            }

            Console.WriteLine("press enter to continue");
            Console.ReadLine();

            //end console app assignment part 2

            //console app assignment part 3

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("console app assignment 3a", j);
            }

            Console.WriteLine("press enter to continue");
            Console.ReadLine();

            for (int k = 0; k <= 5; k++)
            {
                Console.WriteLine("console app assignment 3b");
            }

            Console.ReadLine();

            // end console app assignment part 3

            //console app assignment part 4

            List<string> names2 = new List<string> { "Jesse", "Erik", "Daniel", "Adam" };

            Console.WriteLine("search for a name. (Erik, Jesse, Adam, or Daniel)");

            string userinput2 = Console.ReadLine();

            int foundindex = -1;

            for (int l = 0; l < names2.Count; l++)
            {


                if (names2[l] == userinput2)
                {
                    foundindex = l;
                    break;

                }



            }

            if (foundindex == -1)
            {
                Console.WriteLine("error");
            } else 
            {
                Console.WriteLine(foundindex);
            }


            Console.ReadLine();

            //end console app assignment part 4

            //console app assignment part 5

            List<string> names3 = new List<string> { "Jesse", "Erik", "Erik", "Daniel", "Adam", "Adam" };

            Console.WriteLine("search for a name. (Erik, Jesse, Adam, Daniel, Erik, or Adam)");

            string userinput3 = Console.ReadLine();

            bool foundsomethingelse = false;

            for (int l = 0; l < names3.Count; l++)
            {


                if (names3[l] == userinput3)
                {
                    Console.WriteLine(userinput3 + " is at the " + l + " index");
                    foundsomethingelse = true;


                }



            }

            if (foundsomethingelse == false)
            {
                Console.WriteLine("that is not a name on our list");
            }



            Console.WriteLine("press enter to continue");
            Console.ReadLine();

            //END CONSOLE APP ASSIGNMENT PART 5

            //CONSOLE APP ASSIGNMENT PART 6

            List<string> names4 = new List<string> { "Jesse", "Erik", "Erik", "Daniel", "Adam", "Adam" };
            List<string> repeatNames = new List<string>();

            foreach (string name4 in names4)
            {
                bool seenBefore = repeatNames.Contains(name4);
                if (seenBefore)
                {
                    Console.WriteLine(name4 + " (this is the second time this name apears)");
                } else
                {
                    Console.WriteLine(name4);
                }
                repeatNames.Add(name4);
                
            }



            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            //END CONSOLE APP ASSIGNMENT PART 6

            
        }
    }
}
