
namespace Delegate;

public class Exercise1
{
    // Тип делегата
    public delegate int Num();

    public int RunNum()
    {
        Random rnd = new Random();
        return rnd.Next(1, 10);         
    }
}

