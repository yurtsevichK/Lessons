using System;
using System.Data;


namespace Lessons
{
    class Program
    {
        public static int[,] GetRandomArray(int rows, int columns)
        {
            Random random = new Random();
            var result = new int [rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = random.Next(100);
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            int rows = 5;
            int columns = 5;
            var MyArray = GetRandomArray(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{MyArray[i, j]}\t");
                }

                Console.WriteLine();
            }
        }
    }
}