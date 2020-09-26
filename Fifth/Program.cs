using System;
using static System.Console;

namespace Fifth
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
            var res = 1L;
            var i = 1;
            do
            {
                res *= i;
                i++;
            }
            while (i <= x);
            return res;
        }
    }
}
