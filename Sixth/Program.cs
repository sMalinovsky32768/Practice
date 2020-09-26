using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Sixth
{
    class Program
    {
        static void Main()
        {
            var flag = true;

            while (flag)
            {
                Write("Enter a number: ");
                if (int.TryParse(ReadLine(), out var x))
                {
                    flag = false;

                    AnalysisOfTheInteger(x, new[] { 2, 3, 5, 6, 9 }, out var isPositive, out var isPrimeNumber, out var withoutResuid);

                    var isPositiveStr = !isPositive.HasValue ? "0" : isPositive.Value ? "positive" : "negative";
                    WriteLine($"Number {x} is {isPositiveStr}");

                    var isSimleStr = !isPrimeNumber.HasValue ? "neither simple nor composite"
                        : isPrimeNumber.Value ? "a Prime number" : "a composite number";
                    WriteLine($"Number {x} is {isSimleStr}");

                    if (withoutResuid.Count > 0)
                    {
                        StringBuilder builder;

                        if (withoutResuid.ContainsValue(true))
                        {
                            builder = new StringBuilder($"Number {x}");
                            builder.Append(" is divisible without remainder by ");
                            builder.Append(withoutResuid
                                .Where(i => i.Value)
                                .Select(i => i.Key.ToString())
                                .Aggregate((x, y) => $"{x}, {y}"));
                            WriteLine(builder.ToString());
                        }

                        if (withoutResuid.ContainsValue(false))
                        {
                            builder = new StringBuilder($"Number {x}");
                            builder.Append(" is not divisible without remainder by ");
                            builder.Append(withoutResuid
                                .Where(i => !i.Value)
                                .Select(i => i.Key.ToString())
                                .Aggregate((x, y) => $"{x}, {y}"));
                            WriteLine(builder.ToString());
                        }
                    }
                }
                else
                {
                    WriteLine("Value is not a number");
                }
            }
        }

        /// <summary>
        /// Анализирует число
        /// </summary>
        /// <param name="x">Анализируемое число</param>
        /// <param name="numbers">Массив чисел, для проверки на деление без остатка</param>
        /// <param name="isPositive">
        /// Является ли число положительным.
        /// true - число положительное,
        /// false - число отрицательное,
        /// null - введенное число равно 0
        /// </param>
        /// <param name="isPrimeNumber">
        /// true - число простое,
        /// false - число составное,
        /// null - число не простое, ни составное (0 или отрицательное не составное число)
        /// </param>
        /// <param name="withoutResidue">
        /// Содержит пары ключ-значение, где ключ - число из массива numbers, значение - делится ли число на ключ без остатка
        /// </param>
        static void AnalysisOfTheInteger(int x, int[] numbers, out bool? isPositive, out bool? isPrimeNumber, out Dictionary<int, bool> withoutResidue)
        {
            withoutResidue = new Dictionary<int, bool>();
            if (x == 0)
            {
                isPositive = null;
                isPrimeNumber = null;
                if (numbers != null)
                {
                    foreach (var item in numbers)
                    {
                        withoutResidue.Add(item, true);
                    }
                }
            }
            else
            {
                isPositive = x > 0;
                if (x < 0)
                {
                    isPrimeNumber = null;
                }
                else
                {
                    isPrimeNumber = true;
                    for (var i = 2; i < x; i++)
                    {
                        if (x % i == 0)
                        {
                            isPrimeNumber = false;
                            break;
                        }
                    }
                }
                if (numbers != null)
                {
                    foreach (var item in numbers)
                    {
                        withoutResidue.Add(item, x % item == 0);
                    }
                }
            }
        }
    }
}
