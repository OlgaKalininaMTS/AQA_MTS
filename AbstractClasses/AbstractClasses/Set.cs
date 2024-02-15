using System.Diagnostics;
using System.Xml.Linq;
using AbstractClasses;

namespace AbstractClasses;

public class Set : Product  // ������
{
    public List<Product> Products { get; set; }

    public override void PrintProductInfo()
    {
        Console.WriteLine($"��������: {NameProd}, ����: {PriceProd}");
        foreach (var product in Products)
        {
            product.PrintProductInfo();
        }
    }

    public override bool IsExpired()
    {
        return Products.Any(p => p.IsExpired());
    }
    

}