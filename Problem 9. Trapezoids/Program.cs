using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_9.Trapezoids
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first side:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second side:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height:");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("The area is: {0}", ((a + b) / 2) * h);
        }
    }
}
