namespace Delegate;

public class Example4
{
    // Тип делегата
    private delegate void NoParameters();

    public void Run()
    {
        NoParameters noPrm = delegate   // объявляем анонимный метод
        {
            Console.WriteLine("Have funn!");
        };
        
        noPrm();
    }
}