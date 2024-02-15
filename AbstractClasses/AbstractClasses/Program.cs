using AbstractClasses.BaseFigures;
using AbstractClasses;

////////////////////////////////////// Домашняя работа по AbstractClasses. Задание 1
/*
Figures[] figures = new Figures[5];
figures[0] = new Triangle(5, 4, 6);
figures[1] = new Rectangle(8, 7);
figures[2] = new Circle(3);
figures[3] = new Triangle(3, 3, 3);
figures[4] = new Rectangle(7, 14);

double summmaSquare = 0;
double summmaPerimeter = 0;

foreach (Figures figure in figures)
{
     summmaSquare = summmaSquare + figure.Square();
     summmaPerimeter += figure.Perimeter();
    Console.WriteLine($"Площадь: {figure.Square()}, Периметр: {figure.Perimeter()}");
}
Console.WriteLine($"Сумма площадей всех фигур: {Math.Round(summmaSquare, 2)}, Сумма периметров всех фигур: {Math.Round(summmaPerimeter, 2)}");
*/

////////////////////////////////////// Домашняя работа по AbstractClasses. Задание 2
/*
List<Product> products = new List<Product>
        {
            new Pproduct { NameProd = "Сметана", PriceProd = 105.50, Dateofmanuf = new DateTime(2024, 02, 09), Bestbeforedate = new DateTime(2024, 02, 29) },
            new Consignment { NameProd = "Хлеб", PriceProd = 48.3, Count = 3, Dateofmanuf = new DateTime(2024, 02, 08), Bestbeforedate = new DateTime(2024, 02, 13) },
            new Set { NameProd = "Набор продуктов", PriceProd = 150, Products = new List<Product>
                {
                    new Pproduct { NameProd = "Сметана", PriceProd = 105.50, Dateofmanuf = new DateTime(2024, 02, 09), Bestbeforedate = new DateTime(2024, 02, 29) },
                    new Pproduct { NameProd = "Молоко", PriceProd = 95.80, Dateofmanuf = new DateTime(2024, 02, 05), Bestbeforedate = new DateTime(2024, 02, 19) }
                }
            }
        };
foreach (var product in products)
{
    product.PrintProductInfo();
}

var expiredProducts = products.Where(p => p.IsExpired());
foreach (var product in expiredProducts)
{
    Console.WriteLine($"Просроченный товар: {product.NameProd}");
}

Console.ReadKey();
*/