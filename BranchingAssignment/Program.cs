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
            Console.WriteLine("Please enter your package weight in pounds, rounded up.");
            string PackageWeight = Console.ReadLine();
            int Weight = Convert.ToInt32(PackageWeight);
            if (Weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Please enter package width in inches, rounded up.");
                string PackageWidth = Console.ReadLine();
                int Width = Convert.ToInt32(PackageWidth);
                Console.WriteLine("Please enter package Height.");
                string PackageHeight = Console.ReadLine();
                int Height = Convert.ToInt32(PackageHeight);
                Console.WriteLine("Please enter package Length.");
                string PackageLength = Console.ReadLine();
                int Length = Convert.ToInt32(PackageLength);
                int total = (Width + Height + Length);
                if (total > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                } else
                {
                    int VolumeWeight = (Height * Width * Length * Weight);
                    int ShippingQuote = (VolumeWeight / 100);
                    Console.WriteLine("Your shipping quote is $" + ShippingQuote); 
                    Console.ReadLine();
                }


            }
        }
    }
}
