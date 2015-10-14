using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointInCircle
{
    class Program
    {
        static void Main()
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float radius = 1.5f;
            float sum = (x * x + y * y);
            float multiply = radius * radius;
            bool isInside = sum <= multiply && y > 0;
            if (isInside)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}