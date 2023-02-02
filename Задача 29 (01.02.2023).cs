namespace Задание_29
{
    internal class Program
    {
        static void Main(string[] all)
        {

            Console.Write("Введите любое число : ");
            int A = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[A];

            for (int i = 0; i < A; i++)
            {
                array[i] = new Random().Next(A + 1);
                Console.Write(array[i] + " , ");
            }
            
        }
    }
}