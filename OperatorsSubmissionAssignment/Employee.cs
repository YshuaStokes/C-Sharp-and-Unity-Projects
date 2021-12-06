using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName + " ID: " + Id );


        }
        public void Quit(string name)
        {
            Console.WriteLine(name + ": You can't fire me, cause I quit!! \n *press enter to walk off the job");
            Console.ReadLine();
        }

        public static bool operator== (Employee employee, Employee employee1)
        {
            return employee.Id == employee1.Id;

        }

        public static bool operator!= (Employee employee, Employee employee1)
        {
            return employee.Id != employee1.Id;

        }

        
    }
}
