// See https://aka.ms/new-console-template for more information

using Abstraction;   // из файла класса = namespace

TriangleDeterminent tr1 = new TriangleDeterminent();
//tr1.side1 = 5;
//tr1.side2 = 6;
//tr1.side3 = 7;
//tr1.TriangleResult(5,4,3);      // 5,4,3 прямоугольный

Triangle tr5 = new Triangle();
tr5.SquareResult(1,2,1);



/*
Triangle[] shapes = new Triangle[10];
shapes[0] = new Square { side1 = 2 };
shapes[3] = new Rectangle { side1 = 5, side2 = 2 };
shapes[6] = TriangleDeterminent.CreateTriangle(3, 4, 5);


foreach (var shape in shapes)
{
    shape.Area();
    Console.WriteLine();
}
Console.ReadKey();
*/