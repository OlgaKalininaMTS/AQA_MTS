using System.Reflection;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classes;
public class ConstructorPhone1
{
   
    public ConstructorPhone1(int number, int model) // третий конструктор
    {
        number = number;
        model = model;

         void Print()
        {
            Console.WriteLine($"Номер: {number}  Модель: {model}");

        }

    }

}