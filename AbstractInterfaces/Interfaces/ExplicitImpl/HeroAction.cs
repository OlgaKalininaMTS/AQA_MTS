namespace Interfaces.ExplicitImpl;

//public class HeroAction : BaseAction1, IAction  // HeroAction �������� �� BaseAction1, ������� ��������������� �� IAction

public class HeroAction : BaseAction1, IMovable
{
    void IMovable.Move()
    {
        Console.WriteLine("Move in HeroAction class...");
    }
}