namespace Interfaces.BaseImpl;

public class Circle : Figures    // круг наследуется от базового абстрактного класса
{
    public override void DisplayInformation(string information)
    {
        Console.WriteLine($"Tablet3 Display: {information}");
    }
}