using Collections;
using System.Collections;
using System.Text;

namespace Collections;

//public class DictionaryProducts2    // структура дерева
public class DictionaryProducts2
{
    public void Run()
    {
        // Создаем ArrayList для хранения строк
        ArrayList stringList = new ArrayList();

        // Добавляем элементы в ArrayList
        stringList.Add("Первый");
        stringList.Add("Второй");
        stringList.Add("Третий");

        // Создаем ArrayList для хранения строк в С# 12
        ArrayList stringList1 =
        [
            "Первый",
            2,
            false,
            new StringBuilder("Object")
        ];

        // Выводим элементы ArrayList
        Console.WriteLine("Элементы в ArrayList:");
        foreach (var item in stringList) // Рекомендуемый вариант
        {
            Console.WriteLine(item);
        }
    }
}