namespace Задание_52
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Для создания рандомного массива введите 1");
            Console.WriteLine("Для создания массива с размерами введённых с клавиатуры введите 2");

            int generation = Convert.ToInt32(Console.ReadLine()); 

            Random rand = new();

            if (generation == 1)///Решение с рандомным массивом
            {
                int m = new Random().Next(1, 4);

                int n = new Random().Next(1, 4);

                double[,] array = new double[m, n];

                for (int t = 0; t < m; ++t)///Генерация массива
                {

                    for (int i = 0; i < n; ++i)
                    {

                        array[t, i] = new Random().Next(-10, 10) + Math.Round(rand.NextDouble(), 1);
                        Console.Write(array[t, i] + " | ");

                    }

                    Console.WriteLine();

                }

                Console.Write("Введите число столбца : ");
                int B = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите число строки : ");
                int A = Convert.ToInt32(Console.ReadLine());

                if (B! <= n & A! <= m)
                {
                    Console.WriteLine(array[A - 1, B - 1]);
                }
                else
                {
                    Console.WriteLine($"По координатам {B},{A} числа в массиве нет");
                }
            }

            else if (generation == 2)///Решение с вводом с клавиатуры
            {
                Console.Write("Введите число строки : ");
                int m = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите число столбца : ");
                int n = Convert.ToInt32(Console.ReadLine());

                double[,] array = new double[m, n];

                for (int t = 0; t < m; ++t)///Генерация массива
                {

                    for (int i = 0; i < n; ++i)
                    {

                        array[t, i] = new Random().Next(-10, 10) + Math.Round(rand.NextDouble(), 1);
                        Console.Write(array[t, i] + " | ");

                    }

                    Console.WriteLine();

                }

                Console.Write("Введите число столбца : ");
                int B = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите число строки : ");
                int A = Convert.ToInt32(Console.ReadLine());

                if (B! <= n & A! <= m)
                {
                    Console.WriteLine(array[A - 1, B - 1]);
                }
                else
                {
                    Console.WriteLine($"По координатам {B},{A} числа в массиве нет");
                }
            }
            else ///ошибка вызова
            {
                Console.WriteLine("Команды под данным номером не существует");
            }
        }
    }
}