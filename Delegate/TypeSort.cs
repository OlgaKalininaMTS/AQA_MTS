namespace Delegate;



    public class GnomeSort
{    
    static void Swap(int item1, int item2)  //метод для обмена элементов
    {
        var temp = item1;
        item1 = item2;
        item2 = temp;
    }
    public static int[] Gnome(int[] inputArray)  // гномья сортировка
    {
        var index = 1;
        var nextIndex = index + 1;

        while (index < inputArray.Length)
        {
            if (inputArray[index - 1] < inputArray[index])
            {
                index = nextIndex;
                nextIndex++;
            }
            else
            {
                Swap(inputArray[index - 1], inputArray[index]);
                index--;
                if (index == 0)
                {
                    index = nextIndex;
                    nextIndex++;
                }
            }
        }
        return inputArray;
    }
    
}
public class InsertionSort
{
    static void Swap(int item1, int item2)  //метод для обмена элементов
    {
        var temp = item1;
        item1 = item2;
        item2 = temp;
    }
    public static int[] Insertion(int[] inputArray) //сортировка вставками
    {
        for (var i = 1; i < inputArray.Length; i++)
        {
            var key = inputArray[i];
            var j = i;
            while ((j > 1) && (inputArray[j - 1] > key))
            {
                Swap(inputArray[j - 1], inputArray[j]);
                j--;
            }

            inputArray[j] = key;
        }

        return inputArray;
    }
}
