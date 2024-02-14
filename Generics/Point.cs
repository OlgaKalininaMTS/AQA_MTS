namespace Generics;


    internal class Point<T>
{
    private T x;
    private T y;
      

    public Point(T x, T y) // ����������� � 2 �����������
    {
        this.x = x;
        this.y = y;
    }

    public T X { get => x; set => x = value; }  // ������ � ���������� �����
    public T Y { get => y; set => y = value; }

    public void Print()  // �����, ��������� �������� ���������� ����� ������
    {
        Console.WriteLine($"�������� X: {x}, �������� Y: {y}");
    }
}
