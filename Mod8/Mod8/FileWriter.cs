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
        //public static void Main()
        //{
        //    //string filePath = @"D:\\FileProjectC#\SkillFactory\Student.txt";
        //    //if(!File.Exists(filePath)) //проверяем существование файла
        //    //{
        //    //    //если нет, создаем и записываем в строку
        //    //    using (StreamWriter sw = File.CreateText(filePath))
        //    //    {
        //    //        sw.WriteLine("Олег");
        //    //        sw.WriteLine("Дмитрий");
        //    //        sw.WriteLine("Иван");
        //    //    }
        //    //}
        //    ////открываем файл и читаем его
        //    //using (StreamReader sr = File.OpenText(filePath))
        //    //{
        //    //    string str = "";
        //    //    while ((str = sr.ReadLine()) != null) //пока не кончатся строки - считываем из файла по одной и выводим в консоль
        //    //    {
        //    //        Console.WriteLine(str);
        //    //    }
        //    //}
            
        //    //string filePathProd = @"D:\Education (important) and work\Programmir\C#\Skillfactory\Skillfactory_Mod_NEW\SkillfactoriISMod8\Mod8\Mod8\FileWriter.cs"; // Укажем путь

        //    //// Откроем файл и прочитаем его содержимое
        //    //using (StreamReader sr = File.OpenText(filePathProd))
        //    //{
        //    //    string str = "";
        //    //    while ((str = sr.ReadLine()) != null)
        //    //        Console.WriteLine(str);
        //    //}
        //    //____________________________________________________

        //    string tempFile = Path.GetTempFileName(); //генерация имени файла
            
        //    var fileInfo = new FileInfo(tempFile);

        //    using (StreamWriter sw = fileInfo.CreateText())
        //    {
        //        sw.WriteLine("Игорь");
        //        sw.WriteLine("Андрей");
        //        sw.WriteLine("Сергей");
        //    }

        //    using (StreamReader sr = fileInfo.OpenText())
        //    {
        //        string str = "";
        //        while ((str = sr.ReadLine())!= null)
        //        {
        //            Console.WriteLine(str);
        //        }
        //    }

        //    try
        //    {
        //        string tempFile2 = Path.GetTempFileName();
        //        var fileInfo2 = new FileInfo(tempFile2);

        //        //убедимся, что файл назначения точно отсутстсвует
        //        fileInfo2.Delete();
        //        //копируем информацию
        //        fileInfo.CopyTo(tempFile2);
        //        Console.WriteLine($"{tempFile} скопирован в файл {tempFile2}.");
        //        //удаляем ранее созданный файл
        //        fileInfo.Delete();
        //        Console.WriteLine($"{tempFile} удален.");
        //    }

        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"Ошибка: {e}");
        //    } 

        //}

    }
}
