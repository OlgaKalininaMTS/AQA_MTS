using Collections;

namespace Collections;

public class Product
{
    public int Id { get; set; }
    public string NameProd { get; set; }
    public decimal Price { get; set; }
    public int QuantityStock { get; set; }

    public Product(int id, string name, decimal price, int quantity)
    {
        Id = id;
        NameProd = name;
        Price = price;
        QuantityStock = quantity;
    }
}