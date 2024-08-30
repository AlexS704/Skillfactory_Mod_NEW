namespace Mod8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Получение информации о дисках
            //DriveInfo[] drives = DriveInfo.GetDrives();

            //foreach (DriveInfo drive in drives)
            //{
            //    Console.WriteLine($"Название: {drive.Name}");
            //    Console.WriteLine($"Тип: {drive.DriveType}");
            //    if (drive.IsReady)
            //    {
            //        Console.WriteLine($"Объем: {drive.TotalSize}");
            //        Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
            //        Console.WriteLine($"Метка: {drive.VolumeLabel}");
            //    }
            //}

            //Получить все файлы и папки корневого каталога

            GetCatalogs();

        }

        static void GetCatalogs()
        {
            string dirName = @"C:\\"; //прописываем путь к корневой директории

            if (Directory.Exists(dirName)) // Проверка на существование директории
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetFiles(dirName); //получение всех директорий корневого каталога

                foreach (string d in dirs) //выводим все директории
                {
                    Console.WriteLine(d);
                }

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName); //Получаем все файлы корневого каталога

                foreach (string f in files) //Вывод файлов
                {
                    Console.WriteLine(f);
                }
            }
        }

    }
}
