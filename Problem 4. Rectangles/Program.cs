using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_4.Rectangles
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double p = 2 * (width + hight);
            double a = width * hight;
            Console.WriteLine("Perimeter: {0}, Area: {1}", p, a);

        }
    }
}