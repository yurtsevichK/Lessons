using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            value = int.Parse(Console.ReadLine());

            if (value % 2 == 1)
            {
                Console.WriteLine("Value is odd");
            }
            else
            {
                Console.WriteLine("Value is even");
            }
        }
    }
}