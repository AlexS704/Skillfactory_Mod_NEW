
namespace Task1_Mod5
{
    internal class Program
    {
        static string ShowColorsUser(string userName, int userAge)
        //static - модификатор метода
        //void - тип данных, означающий "ничего", "пустой" - с таким типом данных ничего не возвращается в метод
        //при указании конкретного типа данных (например string) в названии метода должны быть указаны параметры

        {

            Console.WriteLine("{0}, возраст:{1}" + $"{Environment.NewLine}Напишите свой любимы цвет на английском с меленькой буквы", userName, userAge);

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

       static string GetDataFromConsole() => Console.ReadLine(); //такая запись возможна, только если в методе одна операция

        //---------------------------------------------------------------------------

        static int[] GetArrayFromConsole(int arrayDimension = 5)
        {
            var arrayUser = new int[arrayDimension];
           
                        
            for (int i = 0; i < arrayUser.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0} ", i + 1);
                arrayUser[i] = int.Parse(Console.ReadLine());                                              
            }

            Console.WriteLine(arrayUser);

            /*//Сортировка одномерного массива внутри метода
            //Сортировка вынесена в метод SortArray

            //var array = new int[] { 5, 6, 9, 1, 2, 3, 4 }; если задать массив напрямую

            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];

                        array[i] = array[j];

                        array[j] = temp;
                    }
                    
                }
            }

            foreach (var item in array)
            {
                Console.Write(item);
                              
            }
           
            //---------------------------------------

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            */            
            return arrayUser;
        }
          

        //----------------------------------------------------------------------------

        static int[] SortArray(int[] arrayUser)
        {
            //Сортировка принятого массива
            int temp;

            for (int i = 0; i < arrayUser.Length; i++)
            {
                for (int j = i + 1; j < arrayUser.Length; j++)
                {
                    if (arrayUser[i] > arrayUser[j])
                    {
                        temp = arrayUser[i];
                        arrayUser[i] = arrayUser[j];
                        arrayUser[j] = temp;
                    }
                }
            }
          
            return arrayUser;
        }
           
        //----------------------------------------------------------------------------

        static void ShowColors(string userName = "Александр", params string[] favcolors)
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
            //oldname = "Александр";
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
        }

        //---------------------------------------------------------------------------
        static void SortComplexArray(int[,] arr)
        {
            int temp;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                        if (arr[i, j] > arr[i, k])
                        {
                            temp = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = temp;
                        }
            }
        }



        //----------------------------------------------------------------------------
        //----------------------------------------------------------------------------
        static void Main(string[] args)
        {

            var array = GetArrayFromConsole(10);
            
            var sortedarray = SortArray(array);
          
            ShowArray(array,true);



            //string name = Console.ReadLine();

            //GetName(ref name);
            //string name = Console.ReadLine();
            // GetName(ref name);

            // Console.WriteLine(GetName);
            // Console.WriteLine(oldname);
            // Console.WriteLine(name);
            //Console.WriteLine(oldname);

            //var Myname = "Алекс";
            //Console.WriteLine(Myname);

            //ChangeName(ref Myname);

            //Console.WriteLine(Myname);
            //Console.ReadKey();


            //int Myage = 32;
            //Console.WriteLine(Myage);

            //ChangeAge(Myage);

            //Console.WriteLine(Myage);
            //Console.ReadKey();            
            //-----------------------------------------------------------------------




            //-----------------------------------------------------------------------

            (string userName, string[] Dishes) DishesUser; //М5 - зд.1

            DishesUser.Dishes = new string[5];

            Console.WriteLine("Введите свое имя: ");
            DishesUser.userName = Console.ReadLine();

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
            var (myName,myAge) = ("Александр", 32);

            Console.WriteLine("Мое имя: {0}", myName);
            Console.WriteLine("Мой возраст: {0}", myAge);


            (string userName,int userAge) anketaUser;

            Console.Write("Введите свое имя: ");
            anketaUser.userName = Console.ReadLine();
                        
            Console.Write("Введите свой возраст цифрами: ");
            anketaUser.userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketaUser.userName);
            Console.WriteLine("Ваш возраст: {0}", anketaUser.userAge);

            Console.ReadKey();

           //-----------------------------------------------------------------------
            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {

                favcolors[i] = ShowColorsUser(anketaUser.userName, anketaUser.userAge);
                
            }
                                   
            Console.WriteLine("Ваши любимые цвета: ");
            /*foreach (var userLikeColors in favcolors)
            {
                Console.WriteLine(userLikeColors);
            }
            
            Console.ReadKey();
            */
            //-----------------------------------------------------------------------
            //ShowColors(anketaUser.userName, favcolors);
            ShowColors();



            int[,] arr = { { - 5, 6, 9, 1, 2, -3}, { - 8, 8, 1, 1, 2, -3}};

            SortComplexArray(arr);









        }



    }
}