namespace Задание_36
{
    internal class Program
    {
        static void Main(string[] all)
        {

            Console.Write("Введите количество чисел массива : ");
            int A = Convert.ToInt32(Console.ReadLine());

            if (A > 1)
            {
                int[] array = new int[A];
                int k = 0;


                for (int i = 0; i < A; i++)
                {
                    array[i] = new Random().Next(100);

                    if (i % 2 != 0)
                    {
                        k = k + array[i];
                    }
                    Console.Write(array[i] + " , ");
                }
                Console.WriteLine($"Количество чётных чисел в массиве :{k}");
            }

            else
            {
                Console.WriteLine("Ошибка !!! Массив слишком мал для вычислений");
            }
        }
    }
}
