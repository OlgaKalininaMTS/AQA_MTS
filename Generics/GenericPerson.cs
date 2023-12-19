namespace Generics;

public class GenericPerson<T>  // что будет зависеть от данного класса: вместо Т можно использовать любую букву
{
    public T Id { get; set; }   // вариативное свойство id - вместо типа пишем Т
    public string Name { get; }

    public GenericPerson(T id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Print()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}");
    }
}