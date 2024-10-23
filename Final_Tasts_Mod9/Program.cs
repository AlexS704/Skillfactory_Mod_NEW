namespace Final_Tasks_Mod9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var exception = new Exception[]
          {
               new ArgumentNullException("--------------ArgumentNullException---------"),
               new ArgumentException("-----------ArgumentException-----------"),
               new MyCustomException("----------MyCustomException------"),
               new InvalidOperationException ("----------InvalidOperationException-------------"),
               new NotImplementedException ("----------NotImplementedException--------------")
          };

            foreach (var ex in exception)
            {

                try
                {
                    throw ex;
                }

                catch (Exception e)
                {
                    Console.WriteLine (e.Message);
                   
                }
            }



        }
    }

    public class MyCustomException : Exception
    {
               
        public MyCustomException(string message) : base(message) { }
    }
}
