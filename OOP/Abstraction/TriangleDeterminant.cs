namespace Abstraction;

//public class TriangleDeterminent : Triangle   // определитель типа треугольника

   public class TriangleDeterminent
    {
    public static Triangle CreateTriangle(double sidea, double sideb, double sidec)
    {
        if (sidea == sideb || sidea == sidec || sideb == sidec)
        {
            // return "равнобедренный";
            return new Triangle1 { Side1 = sidea, Side2 = sideb, Side3 = sidec };
        }
        if (sidea == sideb && sidea == sidec && sideb == sidec)
        {
            //resultTr = "равносторронний";
            return new Triangle2 { Side1 = sidea, Side2 = sideb, Side3 = sidec };
        }
        if (sidea != sideb && sidea != sidec && sideb != sidec)
        {
            // resultTr = "разносторонний";
            return new Triangle4 { Side1 = sidea, Side2 = sideb, Side3 = sidec };
        }
 
      else  /*((Math.Pow(sidea, 2) == Math.Pow(sideb, 2) + Math.Pow(sidec, 2)) || (Math.Pow(sideb, 2) == Math.Pow(sidea, 2) + Math.Pow(sidec, 2)) || Math.Pow(sidec, 2) == Math.Pow(sidea, 2) + Math.Pow(sideb, 2))*/
             {
                 // resultTr = "прямоугольный";
                 return new Triangle4 { Side1 = sidea, Side2 = sideb, Side3 = sidec };
             }

            
        }
       
        //  Console.WriteLine($"Тип треугольника: {resultTr}");
    }



/* if ((sidea > sideb && sidea > sidec) || (sideb > sidea && sideb > sidec) || (sidec > sidea && sidec > sideb))
        {
            double a = Math.Pow(sidea, 2);
            double b = Math.Pow(sideb, 2);
            double c = Math.Pow(sidec, 2);

             if ((Math.Pow(sidea, 2) == Math.Pow(sideb, 2) + Math.Pow(sidec, 2)) || (Math.Pow(sideb, 2) == Math.Pow(sidea, 2) + Math.Pow(sidec, 2)) || Math.Pow(sidec, 2) == Math.Pow(sidea, 2) + Math.Pow(sideb, 2))
             {
                 // resultTr = "прямоугольный";
                 return new Triangle4 { Side1 = sidea, Side2 = sideb, Side3 = sidec };
             }

           //else 
            // {
                 // resultTr = "прямоугольный";
            //     return Console.WriteLine("Фигура не треугольник");
            // }
        }
       
        //  Console.WriteLine($"Тип треугольника: {resultTr}");
    }
}
*/

// public void Print(string TriangleType)
// Console.WriteLine($"Тип треугольника: {TriangleType}");