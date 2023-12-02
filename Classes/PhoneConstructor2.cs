using Classes;
using System.Xml.Linq;
namespace Classes;
public class PhoneConstructor2
{
   public string number;   // номер
    public string model;      // модель
    
   
    public PhoneConstructor2(string number, string model) // второй конструктор
    {
        this.number = number;             //"8-999-99-999-99";
        this.model = model;              //"samsung";
    }

    public void Print() => Console.WriteLine($"Конструктор 2:\nНомер: {number}  Модель: {model}");

}