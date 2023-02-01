namespace Задание_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a, b, c, i;

                Console.WriteLine("Введите возводимое число : ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите степень : ");
                b = Convert.ToInt32(Console.ReadLine());

                i = 0;
                c = 1;

                while (i < b)
                {
                    c = c * a;
                    i = i + 1;
                }

                Console.WriteLine($"Вторая цифра этого числа : {c}");
                Console.WriteLine();

            }
        }
    }
}