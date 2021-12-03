using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Math MathCall = new Math();
            Console.WriteLine(MathCall.MyMethod(2));

            Console.WriteLine(MathCall.MyMethod(2.0));

            Console.WriteLine(MathCall.MyMethod("4"));
            
            Console.ReadLine();
        }
    }
}
