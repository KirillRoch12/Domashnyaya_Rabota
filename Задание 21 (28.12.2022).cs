using System;
using static System.Net.Mime.MediaTypeNames;

while (true)
{

    double a1, a2, a3, b1, b2, b3, S;

    Console.WriteLine("Введите первые кардинаты : ");
    a1 = Convert.ToInt32(Console.ReadLine());
    a2 = Convert.ToInt32(Console.ReadLine());
    a3 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите вторые кардинаты : ");
    b1 = Convert.ToInt32(Console.ReadLine());
    b2 = Convert.ToInt32(Console.ReadLine());
    b3 = Convert.ToInt32(Console.ReadLine());

    S = Math.Pow((Math.Pow(a1 - b1, 2) + Math.Pow(a2 - b2, 2) + Math.Pow(a3 - b3, 2) * 1.0), 0.5);

    Console.WriteLine($" расстояние между точками равно : {Math.Round(S, 2)}");
    Console.WriteLine();
}
