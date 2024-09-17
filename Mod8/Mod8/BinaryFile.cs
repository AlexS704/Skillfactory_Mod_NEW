using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mod8
{
    public class BinaryFile
    {
        const string SettingsFileName = @"C:\\Users\Александр\Desktop\BinaryFile.bin";

        static void Main()
        {
            WriteValues();
            
            ReadValues();
        }

        static void WriteValues()
        {
            OperatingSystem os = Environment.OSVersion;
            
            using (BinaryWriter writer = new BinaryWriter(File.Open(SettingsFileName, FileMode.Create)))
            {
                DateTime dt = new DateTime();
                writer.Write($"Файл изменен {DateTime.Now} на компьютере с ОС {os}");
            }
        }
        
        static void ReadValues()
        {
            //float FloatValue;
            string StringValue;
           // int IntValue;
            //bool BoleanValue;

            if (File.Exists(SettingsFileName))
            {
                using (BinaryReader reader = new 
                        BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
                {
                    //FloatValue = reader.ReadSingle();
                    StringValue = reader.ReadString();
                   // IntValue = reader.ReadInt32();
                    //BoleanValue = reader.ReadBoolean();
                }

                Console.WriteLine("Данные из файла BinaryFile.bin: " + StringValue);
            }
        }

    }
}
