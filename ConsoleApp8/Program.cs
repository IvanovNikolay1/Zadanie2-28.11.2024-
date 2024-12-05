namespace ConsoleApp8
{
    internal class Program
    {
        static string TrimString(string phrase, int len)
        {
            return phrase.Length <= len ? phrase : phrase.Substring(0, len - 3) + "...";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string input_string = Console.ReadLine();
            Console.WriteLine("Введите максимальную длину: ");
            int maxLenght;
            while (!int.TryParse(Console.ReadLine(), out maxLenght) || maxLenght < 1)
            {
                Console.WriteLine("Пожалуста, введите положительное число");
            }

            string trimPhrase = TrimString(input_string, maxLenght);
            Console.WriteLine("Результат: " + trimPhrase);
        }
    }
}
