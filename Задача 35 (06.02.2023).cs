namespace задание_35
{
    internal class Program
    {
        static void Main(string[] all)
        {

            int A = 123;

            int[] array = new int[A];
            int k = 0;


            for (int i = 0; i < A; i++)
            {
                array[i] =new Random().Next(0 , 150);

                if ( 10 < array[i] & array[i] < 99 )
                {
                    k++;
                }

                if (i % 10 ! == 0)
                {
                    Console.WriteLine(" ");
                }

                Console.Write(array[i] + " , ");
            }
            
            Console.WriteLine(" ");
    
            Console.WriteLine($"количество элементов массива, значения которых лежат в отрезке [10,99] :{k}");
            Console.WriteLine(" ");

        }
    }
}