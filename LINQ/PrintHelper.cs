namespace LINQ;

public class PrintHelper
{
    public static void Print<T>(IEnumerable<T> array, Action<T> action)  // первый параметр - массив с неизвестным типом (общим), делегат Action с обим типом данных
    {
        foreach (T item in array)
        {
            action(item);
        }
    } 
}