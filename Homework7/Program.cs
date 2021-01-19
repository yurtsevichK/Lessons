using System;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            uint evenNumbersCount = 0;
            uint oddNumbersCount = 0;

            Console.WriteLine("Введите первое число диапазона");
            int curentvalue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последнее число диапазона");
            int limit = int.Parse(Console.ReadLine());

            while (curentvalue <= limit)
            {
                if (curentvalue % 2 == 0)
                {
                    evenNumbersCount++;
                }
                else
                {
                    oddNumbersCount++;
                }

                curentvalue++;
            }

            Console.WriteLine("Количество четных чисел:" + evenNumbersCount);
            Console.WriteLine("Количество нечетных чисел:" + oddNumbersCount);
            Console.ReadLine();
        }
    }
}