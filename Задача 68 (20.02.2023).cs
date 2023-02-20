namespace Задание_68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int Akkerman(int m, int n)
                {
                    if (m == 0)
                    {
                        return n + 1;
                    }
                    else if (n == 0 && m > 0)
                    {
                        return Akkerman(m - 1, 1);
                    }
                    else
                    {
                        return (Akkerman(m - 1, Akkerman(m, n - 1)));
                    }
                }

                Console.WriteLine("Введите число M: ");
                int m = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число N: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (m > 0 && n > 0)
                {
                    Console.WriteLine(Akkerman(m, n));
                }
                else
                {
                    Console.WriteLine(" Данные числа являются отрицательными ");
                }
            }
        }
    }
}