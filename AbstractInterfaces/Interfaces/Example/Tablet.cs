namespace Interfaces;

// Класс планшета, также реализующий интерфейс
public class Tablet : IDisplayable   // создали контракт между классом и интерфейсом
//public class Tablet : Smartphone, IDisplayable   // можно и так

{
    public int SerialNumber;
    public void DisplayInformation(string information)
    {
        // Реализация отображения на экране планшета
        Console.WriteLine($"Tablet Display: {information}");
    }

    public void DrawBorders()   // метод базовой имплементации
    {
        Console.WriteLine("Tablet: Рисуем границы");
    }
}