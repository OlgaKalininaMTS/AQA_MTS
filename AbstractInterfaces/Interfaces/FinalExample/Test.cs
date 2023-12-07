namespace Interfaces.FinalExample;

public abstract class Test    // не нужно создавать экземпл€р класса
{
    // свойства
    public string Name { get; set; }   // автосвойство
    public string Description { get; set; }

    public abstract void Run();  // метод запуска - абстрактный метод
}
