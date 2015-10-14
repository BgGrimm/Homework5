using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddOrEvenInteger
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 2 != 0);
        }
    }
}
