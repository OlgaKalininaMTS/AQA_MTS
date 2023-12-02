using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classes;
using Classes;

public class Phone
{
    public string number;   // номер
    public string model;      // модель
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
    public void getNumber(string number)
    {
        Console.WriteLine($"Номер телефона: {number}");
    }
}


