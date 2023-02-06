namespace Задание_34
{
    internal class Program
    {
        static void Main(string[] all)
        {

            Console.Write("Введите любое число : ");
            int A = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[A];
            int k = 0;


            for (int i = 0; i < A; i++)
            {
                array[i] = 100 + new Random().Next(999);

                if (array[i] % 2 == 0)
                {
                    k++;
                }
                Console.Write(array[i] + " , ");
            }
            Console.Write($"Количество чётных чисел в массиве :{k}");

        }
    }
}