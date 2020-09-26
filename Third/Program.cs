using static System.Console;

namespace Third
{
    class Program
    {
        private const int constX = 5;
        private const int constY = 10;
        private const int constZ = 15;

        static void Main()
        {
            ResetVariable(out int x, out int y, out int z);
            x += y >> x++ * z;
            WriteLine($"x += y >> x++ * z = {x}");
            WriteLine($"x={x} y={y} z={z}\n");

            ResetVariable(out x, out y, out _);
            z = ++x & y * 5;
            WriteLine($"z = ++x & y * 5 = {z}");
            WriteLine($"x={x} y={y} z={z}\n");

            ResetVariable(out x, out y, out z);
            y /= x + 5 | z;
            WriteLine($"y /= x + 5 | z = {y}");
            WriteLine($"x={x} y={y} z={z}\n");

            ResetVariable(out x, out y, out _);
            z = x++ & y * 5;
            WriteLine($"z = x++ & y * 5 = {z}");
            WriteLine($"x={x} y={y} z={z}\n");

            ResetVariable(out x, out y, out z);
            x = y << x++ ^ z;
            WriteLine($"x = y << x++ ^ z = {x}");
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
