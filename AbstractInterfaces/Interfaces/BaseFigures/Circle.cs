namespace Interfaces.BaseImpl;

public class Circle : Figures    // ���� ����������� �� �������� ������������ ������
{
    public override void DisplayInformation(string information)
    {
        Console.WriteLine($"Tablet3 Display: {information}");
    }
}