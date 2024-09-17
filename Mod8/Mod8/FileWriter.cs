using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mod8
{
    internal class FileWriter
    {
        public static void Main()
        {
            //string tempFile = Path.GetTempFileName(); // используем генерацию имени файла.
            //var fileInfo = new FileInfo(tempFile); // Создаем объект класса FileInfo.

            ////Создаем файл и записываем в него.
            //using (StreamWriter sw = fileInfo.CreateText())
            //{
            //    sw.WriteLine("Игорь");
            //    sw.WriteLine("Андрей");
            //    sw.WriteLine("Сергей");
            //}

            ////Открываем файл и читаем из него.
            //using (StreamReader sr = fileInfo.OpenText())
            //{
            //    string str = "";
            //    while ((str = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(str);
            //    }
            //}

            //try
            //{
            //    string tempFile2 = Path.GetTempFileName();
            //    var fileInfo2 = new FileInfo(tempFile2);

            //    // Убедимся, что файл назначения точно отсутствует
            //    fileInfo2.Delete();

            //    // Копируем информацию
            //    fileInfo.CopyTo(tempFile2);
            //    Console.WriteLine($"{tempFile} скопирован в файл {tempFile2}.");
            //    //Удаляем ранее созданный файл.
            //    fileInfo.Delete();
            //    Console.WriteLine($"{tempFile} удален.");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Ошибка: {e}");
            //}
                     
                       
            FileInfo fi = new FileInfo(@"C:\Users\pogorelov.aleksandr\source\repos\Skillfactory_Mod_NEW\Mod8\Mod8\FileWriter.cs"); // Указать корректный путь

            // Откроем файл и прочитаем его содержимое
            using (StreamWriter sw = fi.AppendText())
            {                
                sw.WriteLine($"// Время запуска: {DateTime.Now}");
            }

            using (StreamReader sr = fi.OpenText())
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                    Console.WriteLine(str);
            }

           
        }

    }
}


// Время запуска: 17.09.2024 15:02:50
