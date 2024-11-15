namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string inputUser = "";

            while (true)
            {
                inputUser = Console.ReadLine();
                try
                {
                    double.Parse(inputUser);
                }

                catch (FormatException)
                {
                    Console.WriteLine("Ошибка. Вы ввели нечисловые данные");
                }

            }
        }
    }
}
