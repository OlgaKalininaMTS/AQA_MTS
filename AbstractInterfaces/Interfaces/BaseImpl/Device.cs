namespace Interfaces.BaseImpl;

public abstract class Device : IDisplayable   // абстрактный класс имплементируется от интерфейса
{
    public abstract void DisplayInformation(string information);  // имплементацией этого метода будет дочерний класс
}