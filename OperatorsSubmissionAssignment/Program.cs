using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student", Id = 1 };

            Employee employee1 = new Employee() { firstName = "Yshua", lastName = "Stokes", Id = 2 };

            employee.SayName();

            employee1.SayName();

            Console.WriteLine(employee == employee1);

            Console.ReadLine();

            IQuittable quittable = new Employee();

            quittable.Quit("Joe");

            Console.ReadLine();
        }
    }
}
