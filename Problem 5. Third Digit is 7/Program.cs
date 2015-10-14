using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_5.Third_Digit_is_7
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool check = (n / 100) % 10 == 7;
            Console.WriteLine("{0}", check);
        }
    }
}
