namespace Abstraction;

public class TriangleDeterminent : Triangle   // ������������ ���� ������������
{
   
    public void TriangleResult(double side1, double side2, double side3)
    {
        if (side1  == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("����������� ��������������");
        }
        if (side1 == side2 && side1 == side3)
        {
            Console.WriteLine("����������� ���������������");
        }
        if (side1 != side2 && side1 != side3 && side2 != side3)
        {
            Console.WriteLine("����������� ��������������");
        }
        else
        {
            Console.WriteLine("����������� �������������");
        }
    }
}
// public void Print(string TriangleType)
// Console.WriteLine($"��� ������������: {TriangleType}");