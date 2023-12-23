namespace Abstraction;

public class Triangle1 : Triangle  // равнобедренный треугольник
{
    public double h;
    public void SquareResult(double Side1, double Side2, double Side3)
   /* {
        resultTri = (side3 * h) / 2;
        Console.WriteLine($"Площадь равнобедренного треугольника равна: {resultTri}");
    }*/

    {
        if (Side1 == Side2 && Side1 != Side3)
        {
             resultTri = (Math.Sqrt(3) / 4) * Side3 * Side3;
        Console.WriteLine($"Площадь равнобедренного треугольника равна: {resultTri}");
        }
        if (Side1 == Side3 || Side1 != Side2)
        {
            resultTri = (Math.Sqrt(3) / 4) * Side2 * Side2;
            Console.WriteLine($"Площадь равнобедренного треугольника равна: {resultTri}");
        }
        if (Side2 == Side3 && Side2 != Side1)
        {
            resultTri = (Math.Sqrt(3) / 4) * Side1 * Side1;
            Console.WriteLine($"Площадь равнобедренного треугольника равна: {resultTri}");
        }
    }


 //   public void Pause() {}
  //  public void Deactivate() {}
}

