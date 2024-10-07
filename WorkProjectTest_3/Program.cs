//static int RandomNumber()
//{
//    return new Random().Next(0, 100);
//}

Func<int> randomNumberDelegate = () =>
{
    return new Random().Next(0, 100);
};
int result = randomNumberDelegate.Invoke();
Console.WriteLine(result);
Console.Read();

//delegate int RandomNumberDelegate();