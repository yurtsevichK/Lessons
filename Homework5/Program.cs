using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double value_1, value_2;

                try
                {
                    Console.WriteLine("Введите первое число");
                    value_1 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    value_2 = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверное значение! Не удалось преобразовать строку в число");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберите операцию '+' '-' '/' '*'");
                ConsoleKey consoleKey = Console.ReadKey().Key;

                Console.WriteLine("");

                switch (consoleKey)
                {
                    case ConsoleKey.Add:
                        Console.WriteLine("Сумма двух чисел = " + (value_1 + value_2));
                        break;
                    case ConsoleKey.Multiply:
                        Console.WriteLine("Произведение двух чисел = " + (value_1 * value_2));
                        break;
                    case ConsoleKey.Divide:
                        Console.WriteLine("Результат от деления двух чисел = " + (value_1 / value_2));
                        break;
                    case ConsoleKey.Subtract:
                        Console.WriteLine("Остаток от вычитания двух чисел = " + (value_1 - value_2));
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}