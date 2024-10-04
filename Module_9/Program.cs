

//Exception exception = new Exception("Ошибка");

//exception.Data.Add("Дата создания:", DateTime.Now);
//exception.HelpLink = "www.Google.com";

//try
//{       
//       throw new ArgumentOutOfRangeException("Аргумент находится за пределами диапазона");
//}
//catch (ArgumentOutOfRangeException ex)
//{

//    Console.WriteLine(ex.Message );

//}
//finally
//{
//    Console.ReadKey();

//}

try
{
    throw new RankException("Сообщение об ошибке");
}

catch (RankException ex)
{
    Console.WriteLine(ex.GetType());
}

finally
{
    Console.Read();
}