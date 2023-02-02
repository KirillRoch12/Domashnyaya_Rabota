namespace Задача_27
{
    internal class Program
    {
        static void Main(string[] args)
         {
            while (true)
            {
                

                Console.WriteLine("Введите число : ");
                int N = Convert.ToInt32(Console.ReadLine());

                int S = 0;

                while (N >= 1)
                {
                    S+= N % 10;
                    N = (N - N % 10) / 10;
                }
                Console.WriteLine($"Сумма цифр данного числа равна : {S}");
                Console.WriteLine();
            }
        }
    }
}