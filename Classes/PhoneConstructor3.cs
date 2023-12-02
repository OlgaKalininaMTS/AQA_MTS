using Classes;
using System.Xml.Linq;
namespace Classes;
public class PhoneConstructor3
{
    public string number;   // номер
    public string model;      // модель
    public int weight;   // вес

    public PhoneConstructor3(string number, string model, int weight) : this(number, model) // первый конструктор
    {
    }
    public PhoneConstructor3(string number, string model)     // второй конструктор
    {
        this.number = number;             //"8-999-99-999-99";
        this.model = model;              //"samsung";
    }
    public void Print() => Console.WriteLine($"Конструктор 3:\nНомер: {number}  Модель: {model}");

}