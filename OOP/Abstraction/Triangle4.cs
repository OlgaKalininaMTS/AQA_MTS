namespace Abstraction;

public class Triangle4 : Triangle // разносторронний треугольник
{
    
    public double p;

    public void SquareResult(double Side1, double Side2, double Side3) 
    {
        p = (Side1 + Side2 + Side3) / 2;

        resultTri = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
    }
 }

