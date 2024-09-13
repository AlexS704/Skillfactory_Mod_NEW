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
            //через конструкцию try/catch            

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\NewDir");
                if (dirInfo.Exists)
                {
                    Console.WriteLine("Каталог существует");
                    //return;
                }
                dirInfo.Create();
                Console.WriteLine("Каталог создан");

                

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
                
            }

            finally
            {
                string dirName = @"C:\\";

                if (Directory.Exists(dirName))
                {
                    Console.WriteLine("Папки:");
                    string[] dirs = Directory.GetDirectories(dirName);

                    int countFolders = 0;
                    foreach (string d in dirs) //выводим все директории
                    {
                        Console.WriteLine(d);
                        countFolders++;
                    }
                    Console.WriteLine($"Количество папок в списке: {countFolders}");
                    Console.WriteLine();
                    Console.WriteLine("Файлы:");

                    string[] files = Directory.GetFiles(dirName); //Получаем все файлы корневого каталога

                    int countFiles = 0;
                    foreach (string f in files) //Вывод файлов
                    {
                        Console.WriteLine(f);
                        countFiles++;
                    }

                    Console.WriteLine($"Количество файлов в списке: {countFiles}");

                    int result = countFolders + countFiles;
                    Console.WriteLine($"Всего объектов через счетчик:{result}");

                }
            }

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\");
                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }



    }
}
