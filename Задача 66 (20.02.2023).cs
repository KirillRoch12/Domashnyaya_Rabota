namespace Задание_66
{
    internal class Program
    {
            static void Main()
            {
                int summ = 0;
                void OtMDoN(int N, int M)
                {
                    if (N == M) return;
                    {
                        OtMDoN(N, ++M);
                        summ += M;
                        
                    }
                }

                Console.Write(" Задайте значение M : ");
                int M = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Задайте значение N : ");
                int N = Convert.ToInt32(Console.ReadLine());


                OtMDoN(N, M - 1);
                Console.WriteLine(summ);
            }
    }
}
  