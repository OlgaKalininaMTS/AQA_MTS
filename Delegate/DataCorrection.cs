namespace Delegate;

public class DataCorrection  // содержит доп метод, который выдает на экран что цена изменилась на такую-то
{
    public void UpdateData(int price)
    {
        Console.WriteLine($"Data was updated according to price: {price}");
    }
}