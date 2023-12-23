using System.Runtime.CompilerServices;

namespace Delegate;

public class Example5
{
    // Тип делегата
    private delegate void NoParameters();  //
    delegate int Operation(int x, int y);  //  вернуть делегат из метода - целочисленное значение

    public void Run()
    {
        NoParameters noPrm = delegate { Console.WriteLine("Have fun!"); };  // делегат содержит анонимную функцию

        // Делегаты как параметры методов
        Console.WriteLine(Test(noPrm));

        
        

        
        // Возвращение делегатов из метода
        Operation operation = SelectOperation(OperationType.Add);
        Console.WriteLine(operation(10, 4)); // 14

        operation = SelectOperation(OperationType.Subtract);
        Console.WriteLine(operation(10, 4)); // 6

        operation = SelectOperation(OperationType.Multiply);
        Console.WriteLine(operation(10, 4)); // 40
    }
    
    private bool Test(NoParameters noParam)  // метод у которого в качестве параметра делегат
    {
        noParam();
        return true;
    }
   
   // private bool Test(NoParameters delegateValue) {...}
    
    private int Add(int x, int y) => x + y;
    private int Subtract(int x, int y) => x - y;
    private int Multiply(int x, int y) => x * y;

    private Operation SelectOperation(OperationType opType)
    {
        switch (opType)
        {
            case OperationType.Add: return Add;
            case OperationType.Subtract: return Subtract;
            default: return Multiply;
        }
    }
    
}