namespace Abstraction;

public class TriangleDeterminent : Triangle   // ������������ ���� ������������
{
   
    public void TriangleResult(double side1, double side2, double side3)
    {
        if (side1  == side2 || side1 == side3 || side2 == side3)
        {
            resultTr = "��������������";
            //Console.WriteLine("����������� ��������������");
        }
        if (side1 == side2 && side1 == side3)
        {
            resultTr = "���������������";
            //Console.WriteLine("����������� ���������������");
        }
        if (side1 != side2 && side1 != side3 && side2 != side3)
        {
            resultTr = "��������������";
            //Console.WriteLine("����������� ��������������");
        }
        if (side1 > side2 && side1 > side2)
        {
          double  a = Math.Pow(side1, 2);
          double b = Math.Pow(side2, 2);
          double c = Math.Pow(side3, 2);

         /*   if (a = b + c)
            {
            resultTr = "�������������";
            //Console.WriteLine("����������� ��������������");
            }
         */
        }

        else
        {
            resultTr = "�����������";
            //Console.WriteLine("����������� �������������");
        }
        Console.WriteLine($"��� ������������: {resultTr}");
    }
}
// public void Print(string TriangleType)
// Console.WriteLine($"��� ������������: {TriangleType}");