
static void ShowMessage()
{
    Console.WriteLine("Hello world");
}

static int Sum(int a, int b, int c)
{
    return a + b + c;
}

static bool CheckLength(string _row)
{
    if (_row.Length > 3) return true;
    return false;
}


Action showMessageDelegate = ShowMessage;
showMessageDelegate.Invoke();

Func<int, int, int, int> sumDelegate = Sum;
int Result = sumDelegate.Invoke(1, 30, 120);
Console.WriteLine(Result);

Predicate<string> checkLengthDelegate = CheckLength;
bool status = checkLengthDelegate.Invoke("Skill_D");
Console.WriteLine(status);

//delegate void ShowMessageDelegate();
//delegate int SumDelegate(int a, int b, int c);
//delegate bool CheckLengthDelegate(string _row);