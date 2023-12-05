namespace Interfaces;

// Класс смартфона, реализующий этот интерфейс
public class Smartphone : IDisplayable
{
    public int UUID;
    public void DisplayInformation(string information)     //
    {
        // Реализация отображения на экране смартфона
        Console.WriteLine($"Smartphone Display: {information}");
    }
}