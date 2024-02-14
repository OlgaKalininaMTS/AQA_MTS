namespace Generics;


    internal class Point<T>
{
    private T x;
    private T y;
      

    public Point(T x, T y) // конструктор с 2 параметрами
    {
        this.x = x;
        this.y = y;
    }

    public T X { get => x; set => x = value; }  // доступ к внутренним полям
    public T Y { get => y; set => y = value; }

    public void Print()  // метод, выводящий значения внутренних полей класса
    {
        Console.WriteLine($"Значение X: {x}, Значение Y: {y}");
    }
}
