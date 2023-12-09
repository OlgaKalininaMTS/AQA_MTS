namespace Abstraction;

public class Triangle2 : Triangle   // равносторонний треугольник
{
    double c;
   
    
    double b = Math.Sqrt(2);
   // int c = Convert.ToInt32(2);
    
    public void TriangleResult() 
    {
        resultTri = ((Math.Sqrt(3)) / 4) *(side1*side1);
    }
}

