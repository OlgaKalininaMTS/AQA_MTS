namespace Abstraction;

public class TriangleDeterminent : Triangle   // определитель типа треугольника
{
   
    public void TriangleResult(double side1, double side2, double side3)
    {
        if (side1  == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("Треугольник равнобедренный");
        }
        if (side1 == side2 && side1 == side3)
        {
            Console.WriteLine("Треугольник равносторронний");
        }
        if (side1 != side2 && side1 != side3 && side2 != side3)
        {
            Console.WriteLine("Треугольник разносторонний");
        }
        else
        {
            Console.WriteLine("Треугольник прямоугольный");
        }
    }
}
// public void Print(string TriangleType)
// Console.WriteLine($"Тип треугольника: {TriangleType}");