﻿namespace _14.ModifyABitAtAGivenPos
{
    using System;

    class ModifyABit
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            if (v == 0)
            {
                n = n & ~(1 << p);
            }
            else
            {
                n = n | (1 << p);
            }
            Console.WriteLine(n);
        }
    }
}