// See https://aka.ms/new-console-template for more information
using TasksM12;
using BenchmarkDotNet.Attributes;

static void Greetings()
{
    Console.WriteLine("Как Вас зовут?");
    var userName = Console.ReadLine();
    var greetings = "Привет," + userName;
    Console.WriteLine(greetings);
}

static void ArrayFilling()
{
    Console.WriteLine("Сколько элементов будет в массиве?");
    var count = Int32.Parse(Console.ReadLine());
    var array = new string[count];

    for (int i = 0; i < count; i++)
    {
        array[i] = Console.ReadLine();
    }

    Console.WriteLine("Все элементы записаны");
}

static void AgeVerification()
{
    Console.WriteLine("Введите свой возраст: ");
    var age = Int32.Parse(Console.ReadLine());

    if (age > 13)
    {
        Console.WriteLine("Вы успешно зарегистрированы");
    }
    else { Console.WriteLine("Пользователи младше 14 лет не могут быть зерегистрированы"); }
}

//Задание 12.1.5
//static void ShowAds()
//{
//    Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
//    // Остановка на 1 с
//    Thread.Sleep(1000);

//    Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
//    // Остановка на 2 с
//    Thread.Sleep(2000);

//    Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
//    // Остановка на 3 с
//    Thread.Sleep(3000);
//}

//User user = new User();

//user.Name = "Александр";
//user.IsPremium = false;

//string greeting = "Добро пожаловать " + user.Name;

//if (user.IsPremium == true)
//{
//    Console.WriteLine(greeting);
//}
//else
//{
//    Console.WriteLine(greeting);
//    ShowAds();
//}

//Задание 12.4.1
Testing testing = new Testing();

//testing.UseString();
testing.UseStringBuilder();

