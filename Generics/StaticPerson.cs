namespace Generics;

public class StaticPerson<T>  //
{
    public static T? code;  // переменна€ статична€ - имеет только одно значение, зависит от типа, поэтому пропишем “, может быть пустым, поэтому пропишем ?

    public T Id { get; set; }
    public string Name { get; }

    public StaticPerson(T id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Print()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}");
    }
}