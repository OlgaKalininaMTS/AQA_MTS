namespace Abstraction;

public class Triangle4 : Triangle // ��������������� �����������
{
    
    public double p;

    public void TriangleResult() 
    {
        p = (side1 + side2 + side3) / 2;

        resultTri = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
    }
 }

