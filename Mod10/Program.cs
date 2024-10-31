namespace Mod10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Writer writer = new Writer();

            ((IWriter)writer).Write();
            Console.ReadKey();

            var worker = new Worker();

            ((IWorker)worker).Build();
           
        }
    }

    public class Writer : IWriter
    {
        void IWriter.Write()
        {
            throw new NotImplementedException();
        }
    }

    public class Worker : IWorker
    {
        void IWorker.Build()
        {
            throw new NotImplementedException();
        }
    }

    
    public interface IWriter 
    {
        void Write();
    }

    public interface IWorker
    {
        public void Build();
    }
}
