using System.Collections;
using System.Text;
using Collections.Helper;

namespace Collections.IList;   // ArrayList - устаревший класс

public class ArrayListExample     // используются для создания элементов
{
    public void Run()   // метод
    {
        ArrayList stringList = new ArrayList();    // Создаем ArrayList для хранения строк

        // Добавляем элементы в ArrayList
        stringList.Add("Первый");    // значение, кот хотим добавить
        stringList.Add("Второй");
        stringList.Add("Третий");

        // Создаем ArrayList для хранения строк в С# 12
        ArrayList stringList1 =
        [
            "Первый",                     //   это
            2,                           //   все 
            false,                       // элементы
            new StringBuilder("Object")  // одной коллекции
        ];

        // Выводим элементы ArrayList
        Console.WriteLine("Элементы в ArrayList:");
        // foreach (string item in stringList1) // Ошибка
        foreach (var item in stringList) // Рекомендуемый вариант, когда  используем тип var (он сам определяет тип элемента)
        {
            Console.WriteLine(item);
        }

        // Добавляем элементы в ArrayList с разными типами данных
        stringList.Add(4); // Допустимо, но не рекомендуется
        stringList.Add(true); // Допустимо, но не рекомендуется
        stringList.Add(new StringBuilder("Object")); // Допустимо, но не рекомендуется

        // Выводим элементы после добавления разных типов данных
        Console.WriteLine("\nЭлементы в ArrayList после добавления числа и булевого значения:");
        PrintHelper.PrintCollection(stringList);
    }
}