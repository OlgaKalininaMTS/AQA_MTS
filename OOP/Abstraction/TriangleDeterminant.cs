namespace Abstraction;

public class TriangleDeterminent : Triangle   // определитель типа треугольника
{
   
    public void TriangleResult(double side1, double side2, double side3)
    {
        if (side1  == side2 || side1 == side3 || side2 == side3)
        {
            resultTr = "равнобедренный";
            //Console.WriteLine("Треугольник равнобедренный");
        }
        if (side1 == side2 && side1 == side3)
        {
            resultTr = "равносторронний";
            //Console.WriteLine("Треугольник равносторронний");
        }
        if (side1 != side2 && side1 != side3 && side2 != side3)
        {
            resultTr = "разносторонний";
            //Console.WriteLine("Треугольник разносторонний");
        }
        if (side1 > side2 && side1 > side2)
        {
          double  a = Math.Pow(side1, 2);
          double b = Math.Pow(side2, 2);
          double c = Math.Pow(side3, 2);

         /*   if (a = b + c)
            {
            resultTr = "прямоугольный";
            //Console.WriteLine("Треугольник разносторонний");
            }
         */
        }

        else
        {
            resultTr = "неопределен";
            //Console.WriteLine("Треугольник прямоугольный");
        }
        Console.WriteLine($"Тип треугольника: {resultTr}");
    }
}
// public void Print(string TriangleType)
// Console.WriteLine($"Тип треугольника: {TriangleType}");