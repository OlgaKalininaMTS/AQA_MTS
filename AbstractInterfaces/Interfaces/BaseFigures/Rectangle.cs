namespace Interfaces.BaseImpl;

public class Rectangle : IDisplayable  // прямоугольник
{
    public virtual void DisplayInformation(string information)  // virtual переопределяем метод в дочерних классах
    {
        Console.WriteLine($"Device1 Display: {information}");
    }
}