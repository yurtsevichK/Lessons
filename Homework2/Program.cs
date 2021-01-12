using System;

namespace Homework2
{
    class Program
    {
        
        // Узнайте сумму и произведение 3х чисел и выведите его
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа, чтобы узнать их произведение");
            string value1;
            string value2;
            string value3;
            
            value1 = Console.ReadLine();
            value2 = Console.ReadLine();
            value3 = Console.ReadLine();
            
            double sumResult = double.Parse(value1) * double.Parse(value2) * double.Parse(value3);
            double multResult = double.Parse(value1) * double.Parse(value2) * double.Parse(value3);
            Console.WriteLine("Сумма=" + sumResult);
            Console.WriteLine("Произведение=" + multResult);
        }
    }
}