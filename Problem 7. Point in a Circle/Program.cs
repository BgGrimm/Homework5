using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_7.Point_in_a_Circle
{
    class Program
    {
        static void Main()
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            bool InCircle = (((x * x) + (y * y)) <= 2 * 2);
            Console.WriteLine(InCircle);
        }
    }
}
