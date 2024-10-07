
static void Subtract(int x, int y)
{
   Console.WriteLine(x - y);
    
}

static void AddNumbers(int x, int y)
{
    Console.WriteLine(x + y);
}

ShowDelegate showDelegate = Subtract;
showDelegate += AddNumbers;

showDelegate.Invoke(10, 3);

Console.ReadKey();



public delegate void ShowDelegate(int x, int y);
