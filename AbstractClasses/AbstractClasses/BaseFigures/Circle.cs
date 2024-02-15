using AbstractClasses;


namespace AbstractClasses.BaseFigures;

internal class Product : Rectangle  // круг
{
    private double radius;
   
    public Product(double radius)
    {
        this.radius = radius;
    }

    public override double Perimeter()
    {
      return 2 * radius * Math.PI; ;
    }

    public override double Square()
    {
       return Math.PI * radius * radius; ;
    }
}