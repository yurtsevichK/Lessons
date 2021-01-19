using System;


namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            int count = 0;
            while (count < limit)
            {
                count++;
                Console.WriteLine(count);
            }
        }
    }
}