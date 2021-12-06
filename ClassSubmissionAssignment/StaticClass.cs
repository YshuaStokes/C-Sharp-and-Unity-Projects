using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public static class StaticClass
    {
        public static int StaticMultiply(int x)
        {
            return x * x;
        }

        public static void myMethod(out int number)
        {
            number = 7;
        }
    }
}
