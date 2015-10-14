using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_3.Divide_by_7_and_5
{
    class Program
    {
        static void Main()
        {
            double n = int.Parse(Console.ReadLine());
            bool nDevided = (n % 7 == 0 && n % 5 == 0) ?true : false;
            Console.WriteLine(nDevided);
        }
    }
}
