namespace Interfaces.BaseImpl;

public class Rectangle : IDisplayable  // �������������
{
    public virtual void DisplayInformation(string information)  // virtual �������������� ����� � �������� �������
    {
        Console.WriteLine($"Device1 Display: {information}");
    }
}