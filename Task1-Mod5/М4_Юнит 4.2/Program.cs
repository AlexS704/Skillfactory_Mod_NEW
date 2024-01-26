// See https://aka.ms/new-console-template for more information
using System.Drawing;

Console.WriteLine("Цикл for");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Iteration {0}", i);

    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
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
}


Console.WriteLine("Цикл while");
int k = 0;

while (k < 3)
{
    Console.WriteLine(k);

    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
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

    k++;
}

Console.WriteLine("Цикл do");
int t = 0;

do
{
    Console.WriteLine(t);

    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
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

    t++;
}while (t < 3);
