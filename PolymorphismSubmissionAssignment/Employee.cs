using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);


        }
        public void Quit(string name)
        {
            Console.WriteLine(name + ": You can't fire me, cause I quit!! \n *press enter to walk off the job");
            Console.ReadLine();
        }
    }
}
