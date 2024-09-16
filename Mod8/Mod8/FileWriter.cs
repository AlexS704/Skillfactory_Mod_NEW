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
            string filePath = @"D:\\SkillFactory_test\Student.txt";
            if(!File.Exists(filePath)) //проверяем существование файла
            {
                //если нет, создаем и записываем в строку
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("Олег");
                    sw.WriteLine("Дмитрий");
                    sw.WriteLine("Иван");
                }
            }
            //открываем файл и читаем его
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null) //пока не кончатся строки - считываем из файла по одной и выводим в консоль
                {
                    Console.WriteLine(str);
                }
            }
            
            string filePathProd = @"D:\\SkillFactory\Mod8\Tasks_mod_8\Tasks_mod_8/Program.cs"; // Укажем путь

            // Откроем файл и прочитаем его содержимое
            using (StreamReader sr = File.OpenText(filePathProd))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                    Console.WriteLine(str);
            }


        }

    }
}
