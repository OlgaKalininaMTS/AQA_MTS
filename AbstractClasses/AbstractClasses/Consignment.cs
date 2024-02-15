using System.Diagnostics;
using System.Xml.Linq;

namespace AbstractClasses;

public class Consignment : Product  // ������
{
    public int Count { get; set; }

    
    public override void PrintProductInfo()
    {
        Console.WriteLine($"\n������ ");
        Console.WriteLine($"��������: {NameProd}, ���������: {PriceProd}, ���������� (��): {Count}, ���� ������������: {Dateofmanuf}, ���� ��������: {Bestbeforedate}");
    }
    
    public override bool IsExpired()
    {
        return DateTime.Now > Bestbeforedate;
    }
    
}