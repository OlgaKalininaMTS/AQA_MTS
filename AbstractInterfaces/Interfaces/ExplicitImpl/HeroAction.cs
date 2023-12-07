namespace Interfaces.ExplicitImpl;

//public class HeroAction : BaseAction1, IAction  // HeroAction дочерний от BaseAction1, который имплементирован от IAction

public class HeroAction : BaseAction1, IMovable
{
    void IMovable.Move()
    {
        Console.WriteLine("Move in HeroAction class...");
    }
}