using System;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            uint evenNumbersCount = 0;
            uint oddNumbersCount = 0;

            int oddNumbersSum = 0;
            int evenNumbersSum = 0;

            Console.WriteLine("Введите первое число диапазона");
            int curentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последнее число диапазона");
            int limit = int.Parse(Console.ReadLine());

            while (curentValue <= limit)
            {
                if (curentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumbersSum = curentValue + evenNumbersSum;
                }
                else
                {
                    oddNumbersCount++;
                    oddNumbersSum += curentValue;
                }

                curentValue++;
            }

            Console.WriteLine("Количество четных чисел:" + evenNumbersCount);
            Console.WriteLine("Количество нечетных чисел:" + oddNumbersCount);
            Console.WriteLine("Сумма четных чисел:" + evenNumbersSum);
            Console.WriteLine("Сумма нечетных чисел:" + oddNumbersSum);
            Console.ReadLine();
        }
    }
}