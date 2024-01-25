
namespace Task1_Mod5
{
    internal class Program
    {
        static string ShowColorsUser(string username, int userage)
        //static - модификатор метода
        //void - тип данных, означающий "ничего", "пустой" - с таким типом данных ничего не возвращается в метод
        //при указании конкретного типа данных (например string) в названии метода должны быть указаны параметры

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

        
        //---------------------------------------------------------------------------

       static string GetDataFromConsole() => Console.ReadLine();

        //---------------------------------------------------------------------------

        static int[] GetArrayFromConsole(int nam = 5)
        {
            var resoult = new int[nam];
           
                        
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

            /*for (int i = 0; i < resoult.Length; i++)
            {
                Console.WriteLine(resoult[i]);
            }*/
                        
            return resoult;
        }

        //----------------------------------------------------------------------------

        static int[] SortArray(int[] resoult)
        {
            //Сортировка массива
            int temp;

            for (int i = 0; i < resoult.Length; i++)
            {
                for (int j = i + 1; j < resoult.Length; j++)
                {
                    if (resoult[i] > resoult[j])
                    {
                        temp = resoult[i];
                        resoult[i] = resoult[j];
                        resoult[j] = temp;
                    }
                }
            }
          
            return resoult;
        }
           
        //----------------------------------------------------------------------------

        static void ShowColor(string username = "Alex", params string[] favcolors)
        {
            Console.WriteLine("Ваши любимые цвета: ");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }

        //----------------------------------------------------------------------------

        static void ShowArray(int[] array, bool IsSort = false)
        {
            var temp = array;
            if (IsSort)
            {
                temp = SortArray(array);
            }

            foreach(var item in temp)
            {
                Console.WriteLine(item);
            }
        }

        //----------------------------------------------------------------------------

        static void ChangeAge(int age)
        {
            Console.WriteLine("Введите свой возраст");
            age = Convert.ToInt32(Console.ReadLine());
            
        }

        //----------------------------------------------------------------------------
        static void ChangeName(ref string name)
        {
            Console.WriteLine("Введите свой возраст");
            name = Console.ReadLine();
            
        }

        void GetAge(out string Name,  out byte age)
        {
            Name = "Alexandr";
            age = 32;

        }

        //----------------------------------------------------------------------------

        static void GetName(ref string name)
        {
           // oldname = "Александр";
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
        }


        //----------------------------------------------------------------------------
        static void Main(string[] args)
        {
/*
            string name = Console.ReadLine();

            GetName(ref name);

            Console.WriteLine(GetName);
           // Console.WriteLine(oldname);

            //var Myname = "Алекс";
            //Console.WriteLine(Myname);

            //ChangeName(ref Myname);

            //Console.WriteLine(Myname);
            //Console.ReadKey();


            int Myage = 32;
            Console.WriteLine(Myage);
            
            //ChangeAge(Myage);

            Console.WriteLine(Myage);
            Console.ReadKey();            
            //-----------------------------------------------------------------------
            
            var array = GetArrayFromConsole(10);
            ShowArray(array,true);

          
            //-----------------------------------------------------------------------
*/
            (string UserName, string[] Dishes) DishesUser;

            DishesUser.Dishes = new string[5];

            Console.WriteLine("Введите свое имя: ");
            DishesUser.UserName = Console.ReadLine();

            Console.WriteLine("Введите 5 своих любимых блюд.");
            for (int i = 0; i <= DishesUser.Dishes.Length; i++)
            {                
                
                if (i < DishesUser.Dishes.Length)
                {
                    Console.Write("Блюдо {0}: ", i + 1);
                    DishesUser.Dishes[i] = Console.ReadLine();
                }
                
            }
            Console.WriteLine("Список ваших любимых блюд: ");

            foreach (var resoult in DishesUser.Dishes)
            {
                Console.WriteLine(resoult);
            }

            //-----------------------------------------------------------------------
            var (name_new,age) = ("Александр", 27);

            Console.WriteLine("Мое имя: {0}", name_new);
            Console.WriteLine("Мой возраст: {0}", age);

            Console.Write("Введите имя: ");
            name_new = Console.ReadLine();
                        
            Console.Write("Введите возраст с цифрами: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Мое имя: {0}", name_new);
            Console.WriteLine("Мой возраст: {0}", age);

            Console.ReadKey();

/*            //-----------------------------------------------------------------------
            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColorsUser(name, age);
                
            }

            ShowColor();
            
            /*Console.WriteLine("Ваши любимые цвета: ");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
            
            Console.ReadKey();
*/
            //-----------------------------------------------------------------------

            
          







        }



    }
}