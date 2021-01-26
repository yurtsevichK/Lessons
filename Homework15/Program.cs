using System;
using System.Linq;

namespace Homework15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Узнаем максимальное и минимальное значение элемента массива двумя способами
            int[] myArray = {1, 2, 3, 2, 24, 4};
            int minValue = myArray[0];

            Console.WriteLine("Максимальное значение массива: " + myArray.Max());

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
            }

            Console.WriteLine("Минимальное значение массива: " + minValue);
        }
    }
}