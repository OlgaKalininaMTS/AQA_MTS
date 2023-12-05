namespace AbstractClasses.Game;

public class Warrior : Character   // персонаж Воин - дочерний абстрактный класс, может наследоваться как от обычного класса, так и от абстрактного
{
    public Warrior(int level) : base(level)
    {
    }

    public override void Move()   // делаем имплементацию методов из класса Character
    {
        Console.WriteLine("Warrior is moving to...");
    }

    public override void Attack()
    {
        Console.WriteLine("Warrior is attacking to...");
    }

    public override void UseAbility()
    {
        Console.WriteLine("Warrior is using ability to...");
    }

    public void Test()   // не принадлежит абстрактному классу Character 
    {
        Console.WriteLine("Test");
    }
}