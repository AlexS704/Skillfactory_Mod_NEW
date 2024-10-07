static void ShowMessage1()
{
    Console.WriteLine("Метод 1");
}

static void ShowMessage2()
{
    Console.WriteLine("Метод 2");
}

static void ShowMessage3()
{
    Console.WriteLine("Метод 3");
}

static void ShowMessage4()
{
    Console.WriteLine("Метод 4");
}

ShowDelegate showDelegate = ShowMessage1;
showDelegate += ShowMessage2;
showDelegate += ShowMessage3;
showDelegate += ShowMessage4;

showDelegate.Invoke();

Console.ReadKey();

public delegate void ShowDelegate();
