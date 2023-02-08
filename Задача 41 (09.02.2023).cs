namespace Задача_41
{
    
    internal class Program
    {

        static void Main(string[] all)
        {
            bool exit = true;
            int count = 0;
            string mass = "";

            Console.WriteLine("Вводите числа через Enter, Для подсчёта введите слово 'stop'");

            while (exit)
            {
                string i = Console.ReadLine();

                if (i != "stop" & i != "Stop" & i != "STOP")
                {
                    int ConvertI = Int32.Parse(i);

                    if (ConvertI > 0)
                    {
                        count++;
                    }
                    mass = mass + i + ",";
                }
                
                else
                {
                    string str = Convert.ToString(i);

                    exit = false;

                    Console.WriteLine(" ");
                    Console.WriteLine($"Готовый массив чисел :{mass}") ;
                    Console.WriteLine(" ");
                    Console.WriteLine($"Чисел больше 0 :{count}");

                }
            }
        }
    }

}
