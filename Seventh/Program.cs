﻿using System;
using static System.Console;

namespace Seventh
{
    class Program
    {
        static void Main()
        {
            Write("Enter a number: ");
            if (int.TryParse(ReadLine(), out var x))
            {
                try
                {
                    WriteLine($"The factorial of the number {x} ({x}!) is {Factorial(x)}");
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                }
            }
            else
            {
                WriteLine("Value is not a number");
            }
        }

        static long Factorial(int x)
        {
            if (x < 0)
            {
                throw new Exception("Value is a negative");
            }
            if (x == 0 || x == 1)
            {
                return 1;
            }
            return x * Factorial(x - 1);
        }
    }
}
