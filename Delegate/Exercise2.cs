namespace Delegate;

public delegate double Exercise2(double radius);


/*public class Exercise2
{
    delegate T Operation<T, K>(K variable);  // Т возвращаемый тип,  К переменная

    public double Calc(double radius)
    {
        Operation<decimal, int> squareOperation = Square;
        decimal result1 = squareOperation(5);
        Console.WriteLine(result1); 

        Operation<int, int> doubleOperation = Double;
        int result2 = doubleOperation(5);
        Console.WriteLine(result2); 
    }


    private decimal Square(int n) => n * n;
    private int Double(int n) => n + n;
}*/