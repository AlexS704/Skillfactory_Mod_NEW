public static Car LexusHandler()
{
    return null;
}

public static Lexus LexusHandler()
{
    return null;
}

public static void GetParentInfo(Parent p)
{
    Console.WriteLine(p.GetType());
}

public static Parent ParentHandler()
{
    return null;
}

public static Child ChildHandler()
{
    return null;
}

//ковариантность
CarHandler carHandler = LexusHandler;
Console.Read();

//контрвариантность
ChildInfo childInfo = GetParentInfo;
childInfo.Invoke(new Child());

public delegate Car CarHandler();

public delegate Parent HandlerMethod();
delegate void ChildInfo(Child child);

public class Car
{

}

public class Lexus : Car
{

}
//--------------------------------------------
class Parent
{

}

class Child: Parent
{

}