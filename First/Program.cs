using System;
using static System.Console;

namespace First
{
    /// <summary>
    /// Имеется 3 переменные типа int x = 10, y = 12, и z = 3.
    /// Выполните и рассчитайте результат следующих операций для этих переменных
    /// x += y - x++ * z
    /// z = --x - y * 5
    /// y /= x + 5 % z
    /// z = x++ + y * 5
    /// x = y - x++ * z
    /// Перед каждым примером восстановить данные до исходного состояния
    /// </summary>
    class Program
    {
        private const int constX = 10;
        private const int constY = 12;
        private const int constZ = 3;

        static void Main()
        {
            ResetVariable(out int x, out int y, out int z);
            x += y - x++ * z;
            WriteLine($"x += y - x++ * z = {x}");
            WriteLine($"x={x} y={y} z={z}\n");

            ResetVariable(out x, out y, out _);
            z = --x - y * 5;
            WriteLine($"z = --x - y * 5 = {z}");
            WriteLine($"x={x} y={y} z={z}\n");

            ResetVariable(out x, out y, out z);
            y /= x + 5 % z;
            WriteLine($"y /= x + 5 % z = {y}");
            WriteLine($"x={x} y={y} z={z}\n");

            ResetVariable(out x, out y, out _);
            z = x++ + y * 5;
            WriteLine($"z = x++ + y * 5 = {z}");
            WriteLine($"x={x} y={y} z={z}\n");

            ResetVariable(out x, out y, out z);
            x = y - x++ * z;
            WriteLine($"x = y - x++ * z = {x}");
            WriteLine($"x={x} y={y} z={z}\n");

            ReadKey();
        }

        /// <summary>
        /// Восстанавливает переменные до исходного состояния и выводит значения в консоль
        /// </summary>
        static void ResetVariable(out int x, out int y, out int z)
        {
            x = constX;
            y = constY;
            z = constZ;
            WriteLine($"x={x} y={y} z={z}");
        }
    }
}
