using AbstractClasses;
using System.Diagnostics;
using System.Xml.Linq;

namespace AbstractClasses;

public class Pproduct : Product  // ����������� ����� �� �������� ������ Product
{
    
    public override void PrintProductInfo()
    {
        Console.WriteLine($"��������: {NameProd}, ����: {PriceProd}, ���� ������������: {Dateofmanuf}, ���� ��������: {Bestbeforedate}");
    }
    
    public override bool IsExpired()
    {
        return DateTime.Now > Bestbeforedate;
    }
    
}