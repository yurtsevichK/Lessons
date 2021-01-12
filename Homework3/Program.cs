using System;

namespace Homework3
{
    class Program
    {
        
        // Реализуйте ростой конвертер валют
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько вам надо usd?");
            double byn = 2.5;
            string usd = Console.ReadLine();
            double convert = Convert.ToDouble(usd) * byn;
            Console.WriteLine("Вам необходимо " + convert +" byn");
        }
    }
}