﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_8.Prime_Number_Check
{
    class Program
    {
        static void Main()
        {

           Boolean isCorrect = false;
        int n = 0;
        while (!isCorrect)
        {
            Console.WriteLine("Please enter n<=100");
            n = int.Parse(Console.ReadLine());
            if (n <= 100)
            {
                isCorrect = true;
            }
        }
        if (n == 1)
        {
            Console.WriteLine("False");
        }
        int counterPrimes = 1;
        for (int x = 2; x <= n; x++)
        {
            if (n % x == 0)
            {
                counterPrimes++;
              
            }
        }
        Console.WriteLine(counterPrimes <= 2);

    }

        }
}