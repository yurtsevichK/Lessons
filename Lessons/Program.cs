using System;


namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Тип {0,8} |\t.NET {1,8} |\tРазмер = {2} \t| MIN = {3,30}\t| MAX = {4}";

            Console.Title = "Типы данных в C#";
            Console.WriteLine(msg);
        }
    }
}