namespace Task.Mod._13._3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "Подсчитайте, сколько уникальных символов в этом предложении," +
            //    " используя HashSet<T>, учитывая знаки препинания," +
            //    " но не учитывая пробелы в начале и в конце предложения.";
            //char[] chars = text.ToCharArray();

            //var symbols = new HashSet<char>();
            //foreach (var symbol in chars)
            //{
            //    symbols.Add(symbol);
            //}
            //HashSet<char> hSet = [.. chars];
            //Console.WriteLine("Количество символов: " + hSet.Count);

            //Console.WriteLine("Количество символов: " + symbols.Count);

            ////13.3.11
            //var signs = new[] { ',', ' ', '.' };

            //var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //bool containsNumbers = symbols.Overlaps(numbers);
            //Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");

            //// Отбрасываем знаки препинания и заново считаем
            //symbols.ExceptWith(signs);
            //Console.WriteLine($"Символов без знаков препинания:: {symbols.Count}");

            //13.3.12
            while (true)
            {
                Console.WriteLine("Введите текст:");

                var sentence = Console.ReadLine();

                var charcters = sentence.ToCharArray();

                var symbols = new HashSet<char>();

                // добавляем во множество. Сохраняются только неповторяющиеся символы
                foreach (char c in charcters)
                {
                    symbols.Add(c);
                }

                // Выводим результат
                Console.WriteLine($"Всего {symbols.Count} уникальных символов");
                // сохраняем знаки препинания в массив Char
                var signs = new[] { ',', ' ', '.' };

                // сохраняем числовые символы в массив Char
                var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                //  Проверяем, есть ли цифры
                bool containsNumbers = symbols.Overlaps(numbers);
                Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");

                // Отбрасываем знаки препинания и заново считаем
                symbols.ExceptWith(signs);
                Console.WriteLine($"Символов без знаков препинания:: {symbols.Count}");

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
