using AbstractClasses;
using System.Diagnostics;
using System.Xml.Linq;

namespace AbstractClasses;

public class Pproduct : Product  // производный класс от базового класса Product
{
    
    public override void PrintProductInfo()
    {
        Console.WriteLine($"Название: {NameProd}, Цена: {PriceProd}, Дата производства: {Dateofmanuf}, Срок годности: {Bestbeforedate}");
    }
    
    public override bool IsExpired()
    {
        return DateTime.Now > Bestbeforedate;
    }
    
}