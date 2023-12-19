namespace Generics;

public class GenericPerson<T>  // ��� ����� �������� �� ������� ������: ������ � ����� ������������ ����� �����
{
    public T Id { get; set; }   // ����������� �������� id - ������ ���� ����� �
    public string Name { get; }

    public GenericPerson(T id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Print()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}");
    }
}