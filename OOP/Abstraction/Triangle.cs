namespace Abstraction;

public  class Triangle  // класс фигур
{
    public double Side1;
    public double Side2;
    public double Side3;
    public string resultTr;  // для определения типа треугольника
    public double resultTri;
    public void TriangleResult() {}
    public virtual void SquareResult(double side1, double side2, double side3) 
    {
        Console.WriteLine($"Площадь равнобедренного треугольника равна: {resultTri}");
    }

    //   public void Pause() {}
    //  public void Deactivate() {}
}

