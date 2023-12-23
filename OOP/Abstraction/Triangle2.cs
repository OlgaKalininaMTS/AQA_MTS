namespace Abstraction;

public class Triangle2 : Triangle   // равносторонний треугольник
{
    double c;
   
    
    double b = Math.Sqrt(2);
   // int c = Convert.ToInt32(2);
    
    public void SquareResult(double Side1, double Side2, double Side3) 
    {
        resultTri = ((Math.Sqrt(3)) / 4) *(Side1*Side1);
    }
}

