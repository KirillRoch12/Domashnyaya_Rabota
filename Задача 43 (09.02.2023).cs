using System;

namespace Задача_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первые кардинаты : ");
            var b1 = Convert.ToInt32(Console.ReadLine());
            var k1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите вторые кардинаты : ");
            var b2 = Convert.ToInt32(Console.ReadLine());
            var k2 = Convert.ToInt32(Console.ReadLine());

            double x;
            x = ((double)(b2 - b1) / (k1 - k2));

            Console.WriteLine($"Точка пересечения : {x} {k1 * x +b1}") ;


        }
    }
}