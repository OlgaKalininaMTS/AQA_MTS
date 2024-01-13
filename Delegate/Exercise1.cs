
namespace Delegate;

public class Exercise1
{
    // Тип делегата
    public delegate void Num();

    public void RunNum()
    {
        Random rnd = new Random();
        int randomNumber2 = rnd.Next(1, 10);
        Console.WriteLine($"Случайное число: {randomNumber2}");
    }
}

