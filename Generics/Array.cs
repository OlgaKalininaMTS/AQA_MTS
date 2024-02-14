namespace Generics;

public class GenericsArray<T>
{
    private T[] array;

    public GenericsArray()
    {
        array = new T[0];
    }

    public void Add(T val)  // добавление данных
    {
        T[] newArray = new T[array.Length + 1];
        Array.Copy(array, newArray, array.Length);
        newArray[array.Length] = val;
        array = newArray;
    }

    public void Remove(int index)  // удаление данных (по индексу)
    {
        List<T> list = new List<T>(array);
        list.RemoveAt(index);
        array = list.ToArray();
    }

    public T GetElement(int index)  //  получение элемента по индексу
    {
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException();
        }
        return array[index];
    }

    public int GetLength()  // возвращает длину массива
    {
        return array.Length;
    }

    public void PrintArray()
    {
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write($"{array[index]} ");
        }
        Console.WriteLine();
    }

}