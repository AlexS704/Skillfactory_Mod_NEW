namespace Mod10_Tasks1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFile file = new FileManager();
            IBinaryFile binaryFile = new FileManager();
            FileManager fileManager = new FileManager();

            file.ReadFile();
            binaryFile.ReadBinary();
            fileManager.OpenSource();

            Console.ReadKey();
        }
    }
   //переделать имена интерфейсов
    public interface IFile
    {
        void ReadFile();
    }

    public interface IBinaryFile
    {
        void ReadBinary();

        void OpenBinaryFile();
    }

    public class FileManager : IFile, IBinaryFile
    {
        void IFile.ReadFile()
        {
            Console.WriteLine("Чтение файла....");
        }

        void IBinaryFile.ReadBinary()
        {
            Console.WriteLine("Чтение бинарного файла....");
        }

        void IBinaryFile.OpenBinaryFile()
        {
            Console.WriteLine("Открытие бинарного файла");
        }

        public void OpenSource()
        {
            Console.WriteLine("Открытие строки поиска");
        }
    }
}
