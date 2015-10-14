using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_12.Extract_Bit_from_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Index p= ");
            int p = int.Parse(Console.ReadLine());
            n = n >> p;
            Console.WriteLine("bit @ index p={0}", n & 1);
        }
    }
}
