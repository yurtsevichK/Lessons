using System;

namespace Homework12
{
    class Program
    {
        static void Main(string[] args)
        {
            // заполняем массив с консоли, способ кривой

            Console.WriteLine("Введите количество элементов массива");
            int[] myArray = new int[int.Parse(Console.ReadLine())];

            /*
            myArray[0] = int.Parse(Console.ReadLine());
            myArray[1] = int.Parse(Console.ReadLine());
            myArray[2] = int.Parse(Console.ReadLine());
            myArray[3] = int.Parse(Console.ReadLine());
            myArray[4] = int.Parse(Console.ReadLine());*/

            //заполняем массив с консоли, способ ровный
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Введите значения элемента массива под индексом: " + i);

                myArray[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}