using System;
using static System.Console;

namespace Eighth
{
    class Program
    {
        static void Main()
        {
            var flag = true;

            // Пока пользователь не введет положительное число
            while (flag)
            {
                // Запрашиваем количество элементов
                Write("Enter the number of array elements: ");

                if (int.TryParse(ReadLine(), out var count) && count > 0)
                {
                    flag = false;

                    var array = new int[count];

                    // Заполняем массив рандомными числами
                    var random = new Random();
                    for (var i = 0; i < count; i++)
                    {
                        array[i] = random.Next(-100, 100);
                    }

                    // Выводим массив
                    Write("\nOriginal array:");
                    for (var i = 0; i < array.Length; i++)
                    {
                        Write($" {array[i]}");
                    }

                    var reverseArray = MyReverse(array);

                    // Выводим инвертированный массив
                    Write("\nReverse array:");
                    for (var i = 0; i < reverseArray.Length; i++)
                    {
                        Write($" {reverseArray[i]}");
                    }

                    WriteLine("\nSub array");
                    var indexFlag = true;

                    while (indexFlag)
                    {
                        // Запрашиваем начальный индекс
                        Write("Enter start index (based zero): ");
                        if (int.TryParse(ReadLine(), out var index) && index >= 0)
                        {
                            // Если индекс вне диапазона сообщаем пользователю
                            if (index >= array.Length)
                            {
                                WriteLine($"Value {index} exceeds the side of array\n");
                                continue;
                            }
                            indexFlag = false;

                            var subCountFlag = true;

                            while (subCountFlag)
                            {
                                Write("Enter the number of sub array elements: ");
                                if (int.TryParse(ReadLine(), out var subCount) && subCount > 0)
                                {
                                    // Если индекс последнего элемента нового массива вне диапазона оригинального сообщаем пользователю
                                    if (index + subCount > array.Length)
                                    {
                                        WriteLine($"Value {index} + {count} exceeds the side of array\n");
                                        continue;
                                    }
                                    subCountFlag = false;

                                    var subArray = SubArray(array, index, subCount);

                                    Write("Sub array:");
                                    for (var i = 0; i < subArray.Length; i++)
                                    {
                                        Write($" {subArray[i]}");
                                    }
                                }
                                else
                                {
                                    WriteLine("Value is not a positive number\n");
                                }
                            }
                        }
                        else
                        {
                            WriteLine("Value is not a not-nagative number\n");
                        }
                    }
                }
                else
                {
                    WriteLine("Value is not a positive number\n");
                }
            }
        }

        /// <summary>
        /// Возвращает инвертированный массив
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns></returns>
        static int[] MyReverse(int[] array)
        {
            var newArray = new int[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                newArray[^(i + 1)] = array[i];
            }
            return newArray;
        }

        /// <summary>
        /// Возвращает часть исходного массива начиная с index, размерностью count
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <param name="index">Навальный индекс</param>
        /// <param name="count">Количество элементов</param>
        /// <returns></returns>
        static int[] SubArray(int[] array, int index, int count)
        {
            var newArray = new int[count];
            for (var i = 0; i < count; i++)
            {
                newArray[i] = array[index + i];
            }
            return newArray;
        }
    }
}
