namespace Задание_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int i,c;
                Console.WriteLine("Введите трёхзначное число : ");
                c = Convert.ToInt32(Console.ReadLine());

                i = (c % 100) / 10;

                Console.WriteLine($"Вторая цифра этого числа : {i}");
                Console.WriteLine();
            }
        }
    }
}