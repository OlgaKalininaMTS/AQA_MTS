namespace Event;

public class Client
{
    public ClientType Type { get; set; }  // автосвойство
    
    public int Discount { get; set; }  // скидка для клиента
    
    // Добавить во второй части
    public string Email { get; set; }
}