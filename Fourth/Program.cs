using System;
using System.Diagnostics.CodeAnalysis;

namespace Fourth
{
    class Program
    {
        static void Main()
        {
            Console.Write("Your salary: ");
            var salary = double.Parse(Console.ReadLine());
            Console.Write("How many years have you been working? ");
            var experience = double.Parse(Console.ReadLine());
            var premium = CalcutatePremium(salary, experience);
            Console.WriteLine($"With {experience} years of service, the bonus from salary of {salary:C} is {premium:C}");
        }

        /// <summary>
        /// Вычисляет размер премии на основе размера ЗП и выслуги лет
        /// </summary>
        /// <param name="salary">ЗП</param>
        /// <param name="experience">Выслуга в годах</param>
        /// <returns></returns>
        static double CalcutatePremium(double salary, double experience)
            => salary * (experience < 5 ? 0.1
            : experience < 10 ? 0.15
            : experience < 15 ? 0.25
            : experience < 20 ? 0.35
            : experience < 25 ? 0.45 : 0.5);
    }
}
