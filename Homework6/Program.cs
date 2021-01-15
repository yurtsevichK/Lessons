using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            double value_1, value_2;
            string action;

            Console.WriteLine("Введите первое число");
            value_1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите + - / или * ");
            action = Console.ReadLine();

            Console.WriteLine("Введите второе число");
            value_2 = Double.Parse(Console.ReadLine());

            if (action == "+")
            {
                Console.WriteLine("Сумма двух чисел = " + (value_1 + value_2));
            }
            else if (action == "*")
            {
                Console.WriteLine("Произведение двух чисел = " + (value_1 * value_2));
            }
            else if (action == "/")
            {
                if (value_2 == 0)
                    Console.WriteLine(0);
                else

                    Console.WriteLine("Остаток от деления двух чисел = " + (value_1 / value_2));
            }
            else if (action == "-")
            {
                Console.WriteLine("Остаток от вычитания двух чисел = " + (value_1 - value_2));
            }
            else
            {
                Console.WriteLine("Ошибка. Неизвестное действие");
            }
        }
    }
}