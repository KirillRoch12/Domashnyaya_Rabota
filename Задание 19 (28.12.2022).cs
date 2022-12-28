namespace Задача_19
{

    public static class Extensions
    {
        public static string Reverse(this string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }

    public class Example
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите число для проверки на палиндром :");
                string str = Console.ReadLine();

                string reverse = str.Reverse();

                if (str == reverse)
                {
                    Console.WriteLine($"число {str} является палиндромом");
                }
                else
                {
                    Console.WriteLine($"число {str} не является палиндромом");
                }
            }
        }
    }
}
        
    
