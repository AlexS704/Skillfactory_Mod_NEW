namespace Calculator
{
    internal class Program
    {
        static void Main()
        {
            ISummation summation = new Calculator();

            double x, y;

            while (true)
            {
                Console.Write("Введите первое число: ");
                string inputX = Console.ReadLine();

                Console.Write("Введите второе число: ");
                string inputY = Console.ReadLine();

                try
                {
                    x = double.Parse(inputX);
                    y = double.Parse(inputY);

                    double result = summation.ValueSumm(x, y);
                    Console.WriteLine($"Сумма: {result}");

                    break;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод. Поробуйте еще раз.");
                }

              
            }
        }
    }
}
