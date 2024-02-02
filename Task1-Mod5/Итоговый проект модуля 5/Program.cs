namespace Итоговый_проект_модуля_5
{
//  1. Необходимо создать метод, который заполняет данные с клавиатуры по пользователю(возвращает кортеж) : метод 1
//      Имя;
//      Фамилия;
//      Возраст;
//      Наличие питомца;
//      Если питомец есть, то запросить количество питомцев;
//      Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек(заполнение с клавиатуры); метод 2
//      Запросить количество любимых цветов;
//      Вызвать метод, который возвращает массив любимых цветов по их количеству(заполнение с клавиатуры); метод 3
//      Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе; метод 4
//      Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
//      Корректный ввод: ввод числа типа int больше 0.
//  2. Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
//  3. Вызов методов из метода Main.



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя: ");
            string userName = (Console.ReadLine());

            Console.WriteLine("Введите свою фамилию: ");
            string userSurname = Console.ReadLine();

            Console.WriteLine("Введите свой возраст: ");
            byte userAge = Convert.ToByte(Console.ReadLine());
            
            Console.WriteLine("Наличие питомца: введите Да или Нет");
            string petUser = Console.ReadLine();

            bool havingPet;

            if (petUser == "Да")
            {
                havingPet = true;
            }
            else
            {
                havingPet = false;
            }

            

            Console.WriteLine(UserQuestionnaire(userName, userSurname, userAge, havingPet));

            if (havingPet = true)
            {
                Console.WriteLine("Введите колличество Ваших питомцев: ");              
                byte pet_populat = Convert.ToByte(Console.ReadLine());
            }





        }

        static string UserQuestionnaire(string user_name, string user_surname, byte user_age, bool pet_user)
        {

            (string user_name, string user_surname, byte user_age, bool pet_user, byte pet_population) dataUser;

            return dataUser;
        }



    }
}
