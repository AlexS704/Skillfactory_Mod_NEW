using System.Data;
using System.Reflection.PortableExecutable;

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
    
    public interface IWriter
    {
        void Write();
    }

    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void SendMail();
    }

    public interface ICreatable
    {
        void Create();
    }

    public interface IDeletable
    {
        void Delete();
    }

    public interface IUpdatable
    {
        void Update();
    }

    public interface IBook
    {
        public void Read();
    }

    public interface IDevice
    {
        public void TurnOn();
        public void TurnOff();
    }

    public interface IMessenger <out T>
    {
        T DeviceInfo();
    }



    public class FileManager : IWriter, IReader, IMailer
    {
        public void Read()
        {
            throw new NotImplementedException();
        }

        public void SendMail()
        {
            throw new NotImplementedException();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }

    public class Entity : ICreatable, IDeletable, IUpdatable
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    public class ElectronicBook : IBook, IDevice
    {
        void IDevice.TurnOff()
        {
            throw new NotImplementedException();
        }
        void IDevice.TurnOn()
        {
            throw new NotImplementedException();
        }
        void IBook.Read()
        {
            throw new NotImplementedException();
        }


    }

    public class Phone { }
    public class Computer { }

    public class  Viber : IMessenger <Phone>
    {
       public Phone DeviceInfo()
        {
            return null;
        } 
    }
}
