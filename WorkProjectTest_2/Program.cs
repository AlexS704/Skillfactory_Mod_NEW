//static void ShowMessage(string _message)
//{
//    Console.WriteLine(_message);
//}


Action<string> showMessageDelegate = (string _message) =>
{
    Console.WriteLine(_message);
};
showMessageDelegate.Invoke("Hello World!");
Console.Read();

//delegate void ShowMessageDelegate(string _message);
