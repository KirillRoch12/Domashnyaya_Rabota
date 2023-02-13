namespace Задача_47
{
    internal class Program
    {
        static void Main()
        {

            Random rand = new();

            while (true)
            {

                Console.Write("Введите кол-во строк : ");
                int m = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите кол-во столбцов : ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (m != 0 & n != 0)
                {

                    double[,] array = new double[m, n];
                    for (int t = 0; t < m; ++t)
                    {
                        for (int i = 0; i < n; ++i)
                        {
                            array[t, i] = new Random().Next(-10, 10) + Math.Round(rand.NextDouble(), 1);
                            Console.Write(array[t, i] + " | ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.Write("Ошибка !!! невозможно построить матрицу");
                }

            }
        }
    }
}