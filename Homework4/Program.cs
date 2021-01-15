using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;

            Console.WriteLine("Enter value if u wiil know odd or even");

            value = int.Parse(Console.ReadLine());

            if (value % 2 == 0)
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