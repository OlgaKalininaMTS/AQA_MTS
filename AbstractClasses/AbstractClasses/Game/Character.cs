namespace AbstractClasses.Game;

public abstract class Character   // родительский абстрактный класс: не должно быть возможности создать объект данного класса
{                                 // абстрактный класс может содержать как абстрактные методы, так и обычные,но обычный класс не может содержать абстрактный метод
    public int level;  // уровень
    public string name;  // имя персонажа

    public Character(int level)   // метод 
    {
        this.level = this.level;
    }
    
    public abstract void Move();   // абстрактный метод не имеет тело ()
    public abstract void Attack();
    public abstract void UseAbility();

    public void PrintInfo()
    {
        Console.WriteLine($"{name} {level}");
    }
    public abstract string Clan { get;set;}
}