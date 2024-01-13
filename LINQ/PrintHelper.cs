namespace LINQ;

public class PrintHelper
{
    public static void Print<T>(IEnumerable<T> array, Action<T> action)  // ������ �������� - ������ � ����������� ����� (�����), ������� Action � ���� ����� ������
    {
        foreach (T item in array)
        {
            action(item);
        }
    } 
}