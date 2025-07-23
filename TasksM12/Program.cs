// See https://aka.ms/new-console-template for more information
static void Greetings()
{
    Console.WriteLine("Как Вас зовут" ?);
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
