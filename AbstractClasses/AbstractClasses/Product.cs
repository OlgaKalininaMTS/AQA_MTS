using AbstractClasses;


namespace AbstractClasses;

public abstract class Product  // �������
{
    public string NameProd { get; set; }
    public double PriceProd { get; set; }
    public DateTime Dateofmanuf { get; set; } // ���� ������������
    public DateTime Bestbeforedate { get; set; }  // ���� ��������
   
    public abstract void PrintProductInfo();
    public abstract bool IsExpired();
}