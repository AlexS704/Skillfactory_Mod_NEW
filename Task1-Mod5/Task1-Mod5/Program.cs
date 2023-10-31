namespace Task1_Mod5
{
    internal class Program
    {
        static string ShowColor(string username, int userage)
        {
            
            Console.WriteLine("{0}, возраст:{1}" + $"{Environment.NewLine}Напишите свой любимы цвет на английском с меленькой буквы", username, userage);

            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Ваш цвет красный!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Ваш цвет зеленый!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Ваш любимы цвет берюзовый!");
                    break;

                default:

                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("Ваш любимый цвет желтый!");
                    break;


            }

       
            return color;
        }

        //--------------------------------------------------------

       static string GetDataFromConsole() => Console.ReadLine();

        //--------------------------------------------------------

        static int[] GetArrayFromConsole()
        {
            var resoult = new int[5];
                        
            for (int i = 0; i < resoult.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0} ", i + 1);
                resoult[i] = int.Parse(Console.ReadLine());                                               
            }
                                   
            //---------------------------------------
            /*//Сортировка одномерного массива

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];

                        arr[i] = arr[j];

                        arr[j] = temp;
                    }
                    
                }
            }

            foreach (var item in arr)
            {
                Console.Write(item);
                              
            }
            */
            //---------------------------------------

            for (int i = 0; i < resoult.Length; i++)
            {
                Console.WriteLine(resoult[i]);
            }
                        
            return resoult;
        }

        //--------------------------------------------------------------

        static int[] SortArray(int[] arr)
        {
            //Сортировка массива
            int temp;

            for (int i = 0; i < GetArrayFromConsole().Length; i++)
            {
                for (int j = i + 1; j < GetArrayFromConsole().Length; j++)
                {
                    if (GetArrayFromConsole()[i] > GetArrayFromConsole()[j])
                    {
                        temp = GetArrayFromConsole()[i];
                        GetArrayFromConsole()[i] = GetArrayFromConsole()[j];
                        GetArrayFromConsole()[j] = temp;
                    }
                }
            }
            return GetArrayFromConsole();
        }

   

        static void ShowColorsArray(string[] UserColors)
        {
            Console.WriteLine("Ваш любимый цвет");
            foreach (var resoultColor in UserColors)
            {
                Console.WriteLine(resoultColor);
            }
        }
            
        static void Main(string[] args)
        {

            //GetArrayFromConsole();
            SortArray(GetArrayFromConsole());

            //-----------------------------------------------------------------------

            (string UserName, string[] Dishes) User;

            User.Dishes = new string[5];

            Console.WriteLine("Введите свое имя: ");
            User.UserName = Console.ReadLine();

            Console.WriteLine("Введите 5 своих любимых блюд.");
            for (int i = 0; i <= User.Dishes.Length; i++)
            {                
                
                if (i < User.Dishes.Length)
                {
                    Console.Write("Блюдо {0}: ", i + 1);
                    User.Dishes[i] = Console.ReadLine();
                }
                
            }
            Console.WriteLine("Список ваших любимых блюд: ");

            foreach (var resoult in User.Dishes)
            {
                Console.WriteLine(resoult);
            }

            //-----------------------------------------------------------------------
            var (name,age) = ("Александр", 27);

            Console.WriteLine("Мое имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}", age);

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
                        
            Console.Write("Введите возраст с цифрами: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Мое имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}", age);

            Console.ReadKey();

            //-----------------------------------------------------------------------
            var UserColors = new string[3];

            for (int i = 0; i < UserColors.Length; i++)
            {
                UserColors[i] = ShowColor(name,age);
                
            }

            /*Console.WriteLine("Ваши любимые цвета: ");

            foreach (var resoultColor in UserColors)
            {
                Console.WriteLine(resoultColor);
            }

            Console.ReadLine();
            */
            //-----------------------------------------------------------------------


            







        }



    }
}