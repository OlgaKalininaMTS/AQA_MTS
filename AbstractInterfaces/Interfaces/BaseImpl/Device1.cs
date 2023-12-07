namespace Interfaces.BaseImpl;

public class Device1 : IDisplayable
{
    public virtual void DisplayInformation(string information)  // virtual �������������� ����� � �������� �������
    {
        Console.WriteLine($"Device1 Display: {information}");
    }
}