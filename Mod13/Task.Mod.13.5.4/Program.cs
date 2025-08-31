namespace Task.Mod._13._5._4
{
    internal class Program
    {
        public static Stack<string> words = new Stack<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.\n" +
                "Введите pop, чтобы удалить последний добавленный элемент.\n" +
                "Введите peek, чтобы посмотреть последний добавленный элемент без удаления.");
            Console.WriteLine();                     

            while (true)
            {
                var input = Console.ReadLine();
                //if (input == "pop")
                //{
                //    words.Pop();
                //}
                //else if (input == "peek")
                //{
                //    words.Peek();
                //}
                //else
                
                //    words.Push(input);

                switch (input)
                {
                    case "pop":
                        words.TryPop(out string popResult);
                        break;
                    
                    case "peek":
                        words.TryPeek(out string peekResult);
                        break;

                    default:
                        words.Push(input);
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("В стеке:");
                foreach (var word in words)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
