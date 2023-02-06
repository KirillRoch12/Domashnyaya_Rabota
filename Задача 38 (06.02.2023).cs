namespace Задание_38
{
    internal class Program
    {
        static void Main(string[] all)
        {

            Console.Write("Введите длинну массива : ");
            int A = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[A];

            for (int i = 0; i < A; i++)
            {
                array[i] = new Random().Next(100);
                Console.Write(array[i] + " , ");
            }

            int Mini = array[0];
            int Max = array[0];

            for (int i = 0; i < A; i++)
            {
                if (array[i] >= Max)
                {
                    Max = array[i];
                }
                else if (array[i] <= Mini)
                {
                    Mini = array[i];
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine($" Максимальный элемент массива равен {Max} ");
            Console.WriteLine($" Минимальный элемент массива равен {Mini} ");
            Console.WriteLine($" Разница между ними равна :{Max - Mini} ");
        }
    }
}