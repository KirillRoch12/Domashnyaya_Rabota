namespace Задание_64
{
    internal class Program
    {
        static void Main()
        {

            void OtMDoN(int N, int M)
            {
                if (N == M) return;
                {
                    OtMDoN(N, ++M);
                    
                    Console.Write(M + " ");
                }
            }

            Console.Write(" Задайте значение N : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int M = 1;

            OtMDoN(N, M - 1);      
        }
    }
}