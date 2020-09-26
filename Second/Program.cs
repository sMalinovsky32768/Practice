using static System.Console;

namespace Second
{
    /// <summary>
    /// Cоздайте проект Console Application. 
    /// Напишите программу – консольный калькулятор. 
    /// Создайте две переменные. 
    /// Задайте переменным некоторые произвольные значения. 
    /// Предложите пользователю ввести знак арифметической операции. 
    /// Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch. 
    /// Выведите на экран результат выполнения арифметической операции. 
    /// В случае использования операции деления, организуйте проверку попытки деления на ноль. 
    /// И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.
    /// </summary>
    class Program
    {
        static void Main()
        {
            double x = 10.25;
            double y = 75.5;
            Write("Enter sign: ");
            switch (ReadKey().KeyChar)
            {
                case '+':
                    WriteLine($"\n{x} + {y} = {x + y}");
                    break;
                case '-':
                    WriteLine($"\n{x} - {y} = {x - y}");
                    break;
                case '*':
                    WriteLine($"\n{x} * {y} = {x * y}");
                    break;
                case '/':
                    if (y != 0)
                    {
                        WriteLine($"\n{x} / {y} = {x / y}");
                    }
                    else
                    {
                        WriteLine("\nAttempt to divide by zero");
                    }
                    break;
                case '%':
                    if (y != 0)
                    {
                        WriteLine($"\n{x} % {y} = {x % y}");
                    }
                    else
                    {
                        WriteLine("\nAttempt to divide by zero");
                    }
                    break;
            }
        }
    }
}
