using System;

namespace Homework13
{
    class Program
    {
        static void Main(string[] args)
        {
            //вывод массива в обратном порядке

            int[] myArray = {1, 2, 3, 4, 5};

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.Write(myArray[i]+"\t");
            }
        }
    }
}