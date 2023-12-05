namespace Interfaces;

public interface IExample   // можем создать только либо константы, либо статические переменные
{
    // константа
    const int minSpeed = 0;     // минимальная скорость
    // статическая переменная
    static int maxSpeed = 60;   // максимальная скорость  единая для всех
    
    // метод
    void Move();                // движение  метод без тела
    
    // свойство
    string Name { get; set; }   // название
}