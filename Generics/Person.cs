namespace Generics;

public class Person<T, K>  // можно использовать несколько типов для разных параметров
{
    public T Id { get; }
    public K Code { get; set; }
    public string Name { get; }

    public Person(T id, K code, string name) // конструктор
    {
        Id = id;
        Name = name;
        Code = code;
    }
}