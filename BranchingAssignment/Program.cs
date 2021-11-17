using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter your package weight in pounds.");
            string PackageWeight = Console.ReadLine();
            decimal Weight = Convert.ToDecimal(PackageWeight);
            if (Weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Please enter package width in inches.");
                string PackageWidth = Console.ReadLine();
                decimal Width = Convert.ToDecimal(PackageWidth);
                Console.WriteLine("Please enter package Height.");
                string PackageHeight = Console.ReadLine();
                decimal Height = Convert.ToDecimal(PackageHeight);
                Console.WriteLine("Please enter package Length.");
                string PackageLength = Console.ReadLine();
                decimal Length = Convert.ToDecimal(PackageLength);
                decimal total = (Width + Height + Length);
                if (total > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                } else
                {
                    decimal VolumeWeight = (Height * Width * Length * Weight);
                    decimal ShippingQuote = (VolumeWeight / 100);
                    Console.WriteLine("Your shipping quote is $" + ShippingQuote); 
                    Console.ReadLine();
                }


            }
        }
    }
}
