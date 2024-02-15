namespace Interfaces.BaseImpl;

public abstract class Figures : IDisplayable   // треугольник абстрактный класс имплементируется от интерфейса
{
    public abstract void DisplayInformation(string information);  // имплементацией этого метода будет дочерний класс
}