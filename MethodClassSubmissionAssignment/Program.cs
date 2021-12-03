using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math myMath = new Math();

            myMath.MyMethod(x: 3, y: 4);

            Console.ReadLine();
        }
    }
}
