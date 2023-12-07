namespace Interfaces;

public interface IModificators    // объявляем для статических переменных права private, либо protected // интерфейс может наследоваться только от интерфейса
{
    public const int minSpeed = 0;     // минимальная скорость
    private static int maxSpeed = 60;   // максимальная скорость
    public void Move();
    protected internal string Name { get; set; }    // название
}