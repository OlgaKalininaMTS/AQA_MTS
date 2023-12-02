using System.Xml.Linq;

namespace Classes;

public class Phone
{
    // Блок полей (переменных)
    public int number;   // номер
    public int model;      // модель
    public int weight;    // вес
    public string name;

    public void Print()
    {
        Console.WriteLine($"Номер: {number}  Модель: {model} Вес: {weight}");
    }
    public void receiveCall(string name)
    {
        Console.WriteLine($"Звонит: {name}");
    }
    public void getNumber(int number)
    {
        Console.WriteLine($"Номер телефона: {number}");
    }
}

public class ConstructorPhone
{
    public ConstructorPhone()
    {
    }
    public ConstructorPhone(int number, int model) // третий конструктор
    {
    }
    public ConstructorPhone(int number, int model, int weight) // третий конструктор
    {
    }
    
}

