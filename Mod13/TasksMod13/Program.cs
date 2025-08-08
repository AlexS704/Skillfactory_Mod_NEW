namespace TasksMod13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GetArray(new[] {1, 2, 3, 4, 5}));

            //Console.WriteLine(GetArray(new[] { 6, 5, 3, 4, 5 }));

            //13.1.6
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //получаем доступ к раб.столу             

            string fileName = "cdev_Text.txt";
            string filePath = Path.Combine(desktopPath, fileName); //объединяем два фрагмента пути (путь к рабочему столу и имя файла)=полный путь к файлу

            if (File.Exists(filePath))
            {
                try
                {
                    string content = File.ReadAllText(filePath); //читаем содержимое файла(не подходит для больших >1Гб - лучше использовать StreamReader)

                    int worldCount = CountWords(content);

                    Console.WriteLine($"Файл найден: {filePath}");
                    Console.WriteLine($"Количество слов в файле: {worldCount}");
                }
                catch (IOException ex) { Console.WriteLine($"Ошибка при чтении файла: {ex.Message}"); }
            }
            else
            {
                Console.WriteLine("Файл не найден");
            }
        }

        //метод подсчета слов
        static int CountWords(string content)
        {
            //Удаляем лишние пробелы и разбиваем текст на слова
            char[] separatorsText = new char[] { ' ', '\t', '\n', '\r' }; //получаем массив разделителей
            return content.Split(separatorsText, StringSplitOptions.RemoveEmptyEntries).Length; //получаем массив слов без разделителей и возвращаем длину этого массива
        }

        //13.1.4
        static bool GetArray(int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }                            
            }
            return true;
        }
    }
}
