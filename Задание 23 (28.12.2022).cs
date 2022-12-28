namespace Задача_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n,k;

            Console.WriteLine("Сколько кубов от 1 до N нужно вычислить :");
            n = Convert.ToInt32(Console.ReadLine());

            double i = 1;
            while (n >= i)
            {
                k = Math.Pow(i,3);
                Console.WriteLine($"Куб числа {i} равен {k}");
                i = i + 1;
            }
        }
    }
}