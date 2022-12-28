namespace Задание_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int i, c;
                Console.WriteLine("Введите трёхзначное число : ");
                c = Convert.ToInt32(Console.ReadLine());

                if ((c - (c % 100)) / 100 >= 1)
                {
                    i = (c % 100) % 10;
                    Console.WriteLine($"Третья цифра этого числа : {i}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Читсло {c} не является трёхзначным");
                    Console.WriteLine();
                }
            }
        }
    }
}