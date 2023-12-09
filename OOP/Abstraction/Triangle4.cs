namespace Abstraction;

public class Triangle4 : Triangle // разносторронний треугольник
{
    
    public double p;

    public void TriangleResult() 
    {
        p = (side1 + side2 + side3) / 2;

        resultTri = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
    }
 }

