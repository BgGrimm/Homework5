using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_11.Bitwise
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int nRightP = n >> p;
            int bit = nRightP & 1;
            Console.WriteLine(bit);
        }
    }
}
