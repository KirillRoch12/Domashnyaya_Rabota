namespace Задание_52
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Введите число строки : ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число столбца : ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[,] array = new double[m, n];

            for (int t = 0; t < m; ++t)///Генерация массива
            {

                for (int i = 0; i < n; ++i)
                {

                    array[t, i] = new Random().Next(-10, 10);
                    Console.Write(array[t, i] + " | ");
                }

                Console.WriteLine();
                
            }


         
            for (int B = 0; B < n; ++B)///Генерация массива
            {
                double SummStr = 0;

                for (int A = 0; A < m; ++A)
                {

                    SummStr = SummStr + array[A, B];
                    
                }

                Console.WriteLine(Math.Round(SummStr /m,1));

            }
           

            
               

        }
    }
}
