using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student", Id = 1 };

            Employee employee1 = new Employee() { firstName = "Yshua", lastName = "Stokes", Id = 2 };

            //employee.SayName();

            //employee1.SayName();

            //Console.WriteLine(employee == employee1);

            //Console.ReadLine();

            // 1. CREATE A LIST OF AT LEAST 10 EMPLOYEES

            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(employee1);
            employeeList.Add(employee);
            employeeList.Add(new Employee() { firstName = "Joe", lastName = "Mama", Id = 3});
            employeeList.Add(new Employee() { firstName = "Joe", lastName = "Shmoe", Id = 4 });
            employeeList.Add(new Employee() { firstName = "Brandon", lastName = "Herrera", Id = 5 });
            employeeList.Add(new Employee() { firstName = "John", lastName = "Lovell", Id = 6 });
            employeeList.Add(new Employee() { firstName = "Hugo", lastName = "Martin", Id = 7 });
            employeeList.Add(new Employee() { firstName = "Lucas", lastName = "Botkin", Id = 8 });
            employeeList.Add(new Employee() { firstName = "Andrew", lastName = "Huberman", Id = 9 });
            employeeList.Add(new Employee() { firstName = "Master", lastName = "Cheif", Id = 10 });

            // 2. CREATE A LIST OF ALL EMPLOYEES NAMED JOE

            Console.WriteLine("Employees with the first name Joe \n ");

            //foreach (var tempEmployee in employeeList)
            //{
            //    Console.WriteLine(tempEmployee.firstName + " " + tempEmployee.lastName + " Employee ID: " + tempEmployee.Id);
            //}

            List<Employee> JoeList = new List<Employee>();

            foreach (var tempEmployee in employeeList)
            {
                if (tempEmployee.firstName.Equals("Joe"))
                {
                    JoeList.Add(tempEmployee);
                    
                }
            }

            foreach (Employee listjoe in JoeList)
            {
                Console.WriteLine(listjoe.firstName + " " + listjoe.lastName + ", Employee ID: " + listjoe.Id);
            }

            // 3 USE LAMBDA FOR THE SAME THING

            Console.WriteLine("\nSame list of Joes, but with a lambda \n ");

            List<Employee> lamdaList = employeeList.Where(x => x.firstName == "Joe" ).ToList();

            foreach (Employee employee3 in lamdaList)
            {
                Console.WriteLine(employee3.firstName + " " + employee3.lastName + ", ID:" + employee3.Id);
            }

            // 4 USE LAMbDA, MAKE A LIST OF ALL EMPLOYEES WITH AN ID GREATER THAN 5

            Console.WriteLine("\nThese peeps have an ID number greater than 5 \n");

            List<Employee> above5 = employeeList.Where(x => x.Id > 5).ToList();
            
            foreach (Employee employee2 in above5)
            {
                Console.WriteLine(employee2.firstName + " " + employee2.lastName + ", ID:" + employee2.Id);
            }

            //IQuittable quittable = new Employee();

            //quittable.Quit("Joe");

            Console.ReadLine();
        }
    }
}
