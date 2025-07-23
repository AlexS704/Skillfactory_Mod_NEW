namespace TasksMod12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static void Greetings()
            {
                Console.WriteLine("Как Вас зовут" ?);
                var userName = Console.ReadLine();
                var greetings = "Привет," + userName;
                Console.WriteLine(greetings);
            }

            static void ArrayFilling()
            {
                Console.WriteLine("Сколько элементов будет в массиве?")
                int count = Console.ReadLine();
                array = new int[count];

                for (int i = 0; i < count; i++)
                {
                    array[i];
                }


            }

        }
    }
}
