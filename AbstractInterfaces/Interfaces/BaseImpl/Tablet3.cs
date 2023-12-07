namespace Interfaces.BaseImpl;

public class Tablet3 : Device    // наследуется от базового абстрактного класса
{
    public override void DisplayInformation(string information)
    {
        Console.WriteLine($"Tablet3 Display: {information}");
    }
}