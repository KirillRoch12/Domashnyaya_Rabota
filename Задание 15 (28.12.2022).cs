namespace Задание_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int c;
                Console.WriteLine("Введитt цифру, обозначающую день недели : ");
                c = Convert.ToInt32(Console.ReadLine());

                if ((c == 6) || (c == 7))
                {
                    Console.WriteLine($"Цифра {c} является выходным");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Цифра {c} не является выходным");
                    Console.WriteLine();
                }
            }
        }
    }
}