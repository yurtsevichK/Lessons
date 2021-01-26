using System;

namespace Homework14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Узнаем сумму четных чисел массива
            int[] myArray = {1, 2, 3, 2, 24, 4};
            int sumEvenMyArray = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    sumEvenMyArray = myArray[i] + sumEvenMyArray;
                }
            }

            Console.WriteLine(sumEvenMyArray);
        }
    }
}