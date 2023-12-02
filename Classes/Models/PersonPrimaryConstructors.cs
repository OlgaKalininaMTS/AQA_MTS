namespace Classes.Models;

// Set C# 12 для проекта
public class PhoneConstructor1(string name, int age)
{
    public PhoneConstructor1(string name) : this(name, 18)
    {
    }

    public void Print() => Console.WriteLine($"name: {name}, age: {age}");
}