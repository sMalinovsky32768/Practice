﻿using System;
using static System.Console;

namespace Seventh
{
    class Program
    {
        static void Main()
        {
            Write("Enter a number: ");
            if (int.TryParse(ReadLine(), out var x) && x >= 0)
            {
                WriteLine($"The factorial of the number {x} ({x}!) is {Factorial(x)}");
            }
            else
            {
                WriteLine("Value is not a not-nagative number");
            }
        }

        static long Factorial(int x)
        {
            if (x == 0 || x == 1)
            {
                return 1;
            }
            return x * Factorial(x - 1);
        }
    }
}
