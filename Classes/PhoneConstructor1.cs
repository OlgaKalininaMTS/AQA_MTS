namespace Classes;
using Classes;

//public class PhoneConstructor1
public class PhoneConstructor1 
{
    public string number;   // номер
    public string model;      // модель
    public int weight;   // вес

    public PhoneConstructor1() // второй конструктор
    {
        this.number = number;             //"8-999-99-999-99";
        this.model = number;              //"samsung";
        this.weight = weight;
    }

    public void Print() => Console.WriteLine($"Конструктор 1:\nНомер: {number}  Модель: {model} Вес (в граммах): {weight}");
 
}