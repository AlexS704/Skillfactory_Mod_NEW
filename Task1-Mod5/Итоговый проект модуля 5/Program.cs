using System;

namespace Итоговый_проект_модуля_5
{
/*  
 *  1. Необходимо создать метод, который заполняет данные с клавиатуры по пользователю(возвращает кортеж) : метод 1
 *  Имя;+
 *  Фамилия;+
 *  Возраст;+
 *  Наличие питомца;+
 *  Если питомец есть, то запросить количество питомцев;+
 *  Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек(заполнение с клавиатуры); метод 2+
 *  Запросить количество любимых цветов;
 *  Вызвать метод, который возвращает массив любимых цветов по их количеству(заполнение с клавиатуры); метод 3
 *  Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе; метод 4
 *  Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
 *  Корректный ввод: ввод числа типа int больше 0.
 *  2. Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
 *  3. Вызов методов из метода Main.
*/


    internal class Program
    {
        static void Main(string[] args)
        {

            var userAnketa = UserQuestionnaire();           
            Console.WriteLine(userAnketa);


            if (userAnketa.havingPet == true)
            {
                Console.WriteLine("Введите колличество Ваших питомцев: ");

                byte pet_populat = Convert.ToByte(Console.ReadLine());
                var petName = PetNameUser(ref pet_populat);

                Console.WriteLine(petName);

            }

            Console.WriteLine("Введите количество ваших любимых цветов: ");
            
            byte userColorCount = Convert.ToByte(Console.ReadLine());
            ShowColorsUser(ref userColorCount, userAnketa.userName);
                        
        }

        static (string userName, string userSurname, byte userAge, bool havingPet) UserQuestionnaire()

        {

            (string userName, string userSurname, byte userAge, bool havingPet) userAnketa;

            Console.WriteLine("Введите свое имя: ");
            userAnketa.userName = Console.ReadLine();

            Console.WriteLine("Введите свою фамилию: ");
            userAnketa.userSurname = Console.ReadLine();

            Console.WriteLine("Введите свой возраст: ");
            userAnketa.userAge = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Наличие питомца: введите да или нет");
            string petUser = Console.ReadLine();

            bool havingPet;

            if (petUser == "да")
            {
                userAnketa.havingPet = true;
            }
            else
            {
                userAnketa.havingPet = false;
            }
                             
         
            return userAnketa;

        }

        static string[] PetNameUser(ref byte pet_populat)
        {

            string[] petNameArray = new string[pet_populat];

            for (int i = 0; i < petNameArray.Length; i++)
            {
                Console.WriteLine("Введите имя питомца {0}", i + 1);
                petNameArray[i] = Console.ReadLine();
                                
            }

            Console.WriteLine("Клички ваших животных: ");
            foreach (var item in petNameArray)
            {
                Console.WriteLine(item);
            }

            return petNameArray;
        }

        static string[] ShowColorsUser(ref byte countColor, string userName)        
        {

            Console.WriteLine("{0}" + $"{Environment.NewLine}Напишите свои любимые цвета", userName);

            string[] favcolors = new string[countColor];
                        
            for (int i = 0; i < countColor; i++)
            {

                Console.Write(i + 1 + " цвет: ");

                favcolors[i] = Console.ReadLine();
                              
            }

            Console.WriteLine("Ваши любимые цвета: ");
            foreach (var item in favcolors)
            {
                Console.WriteLine(item);
            }
           
            return favcolors;
        }





    }
}
