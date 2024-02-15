using AbstractClasses;

namespace AbstractClasses.BaseFigures;

internal class Triangle : Figures  // треугольник 
{
    private double sideA;
    private double sideB;
    private double sideC;

    protected Triangle() { }
    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public override double Perimeter()
    {
        return sideA + sideB + sideC;
    }

    public override double Square()
    {
        double d;
        d = 0.5 * (sideA + sideB + sideC);
       return Math.Sqrt(d * (d - sideA) * (d - sideB) * (d - sideC));
    }
}