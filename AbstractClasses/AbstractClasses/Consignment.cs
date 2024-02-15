using System.Diagnostics;
using System.Xml.Linq;

namespace AbstractClasses;

public class Consignment : Product  // партия
{
    public int Count { get; set; }

    
    public override void PrintProductInfo()
    {
        Console.WriteLine($"\nПартия ");
        Console.WriteLine($"Название: {NameProd}, Стоимость: {PriceProd}, Количество (шт): {Count}, Дата производства: {Dateofmanuf}, Срок годности: {Bestbeforedate}");
    }
    
    public override bool IsExpired()
    {
        return DateTime.Now > Bestbeforedate;
    }
    
}