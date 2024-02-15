using AbstractClasses;


namespace AbstractClasses;

public abstract class Product  // продукт
{
    public string NameProd { get; set; }
    public double PriceProd { get; set; }
    public DateTime Dateofmanuf { get; set; } // дата производства
    public DateTime Bestbeforedate { get; set; }  // срок годности
   
    public abstract void PrintProductInfo();
    public abstract bool IsExpired();
}