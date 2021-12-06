using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public class Math
    {
        public void Divide(int x)
        {
            

            Console.WriteLine(x + " / 2 = " + (x / 2));
        }

        public int Multiply(int x)
        {
            return x * 2;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public string StringCounter(string input, out int count)
        {
            count = input.Length;
            string phrase = "You typed " + count + " characters";
            return phrase;
        }



    }
}
