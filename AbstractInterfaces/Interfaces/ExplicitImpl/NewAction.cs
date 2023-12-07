namespace Interfaces.ExplicitImpl;

public class NewAction : IAction, IMovable
{
    void IAction.Move()     //метод 1
    {
        Console.WriteLine("IAction: движемся...");
    }

    void IMovable.Move()  //метод 2
    {
        Console.WriteLine("IMovable: движемся...");
    }
}