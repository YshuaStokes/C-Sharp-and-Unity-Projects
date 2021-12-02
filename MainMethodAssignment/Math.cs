using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Math
    {
        public static int MyMethod(int x)
        {
            return 5 + x;
        }

        public static decimal MyMethod(double x)
        {
            int result = Convert.ToInt32(x * 9);
            return result;
        }

        public static string MyMethod(string x)
        {
            string number = x;
            int num = Convert.ToInt32(number);
            
            Console.WriteLine(num * 3);
            return number;
            
        }
       
    }
}
