using System.Collections;
using System.Text;

namespace TasksMod13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GetArray(new[] {1, 2, 3, 4, 5}));

            //Console.WriteLine(GetArray(new[] { 6, 5, 3, 4, 5 }));

            //13.1.6
            //string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //получаем доступ к раб.столу             

            //string fileName = "cdev_Text.txt";
            //string filePath = Path.Combine(desktopPath, fileName); //объединяем два фрагмента пути (путь к рабочему столу и имя файла)=полный путь к файлу

            //if (File.Exists(filePath))
            //{
            //    try
            //    {
            //        string content = File.ReadAllText(filePath); //читаем содержимое файла(не подходит для больших >1Гб - лучше использовать StreamReader)

            //        int worldCount = CountWords(content);

            //        Console.WriteLine($"Файл найден: {filePath}");
            //        Console.WriteLine($"Количество слов в файле: {worldCount}");
            //    }
            //    catch (IOException ex) { Console.WriteLine($"Ошибка при чтении файла: {ex.Message}"); }
            //}
            //else
            //{
            //    Console.WriteLine("Файл не найден");
            //}

            //13.2.6
            //Напишите метод, который на вход принимает любой Arraylist input, а на выходе выдает другой Arraylist с 
            //двумя элементами, где первый — число(сумма целочисленных элементов input), а второй — строка(текст, составленный из строковых элементов input).


            var arrayList = new ArrayList()
            {
                1,
                "Андрей ",
                "Сергей ",
                300,
            };

            //переменная для хранения суммы
            int sum = 0;

            // переменная для хранения текста.
            // Можно было бы использовать String, но в случае когда необходимо выполнять много
            // операций с одной строкой - лучше использовать класс StringBuilder
            StringBuilder text = new StringBuilder();

            //проходим список и проверям элементы на соответствие типу
            foreach (var element in arrayList)
            {
                //если целое число - увеличиваем счетчик
                if (element is int)
                {
                    sum += (int)element;
                }

                //если строка - добавляем текст из нее
                if(element is string s)
                {
                    text.Append(element);
                }
            }

            //результат
            var result = new ArrayList() { sum, text.ToString() };

            //вывод
            foreach (var elem in result)
            {
                Console.WriteLine(elem);
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
