using System;

namespace Homework
{
    class Program
    {
        
        // Узнайте среднее арифметическое двух чисел
        static void Main(string[] args)
        {
            string firstValue;
            string secondValue;

            Console.WriteLine("Enter first value");
            firstValue = Console.ReadLine();


            Console.WriteLine("Enter second value");
            secondValue = Console.ReadLine();

            double result = (Convert.ToDouble(firstValue) + Convert.ToDouble(secondValue)) / 2;
            Console.WriteLine("Average two value:" + result);

        }
    }
}