using Collections.Helper;

namespace Collections.IDictionary;

public class DictionaryExample
{
    public void Run()
    {
        // Создаем словарь с ключами и значениями типа string
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();
     //   Dictionary<string, int> myDictionary = new Dictionary<string, int>(26);   можем задать capasity - размер


        // Добавляем элементы в словарь
        myDictionary.Add("apple", 10);
        myDictionary.Add("banana", 5);
        myDictionary.Add("cherry", 7);
/*
        // Проверяем наличие ключа в словаре
        bool containsKey = myDictionary.ContainsKey("banana");
        Console.WriteLine($"ContainsKey(\"banana\"): {containsKey}");
*/
        // Получаем значение по ключу

        int result = myDictionary["apple"];
        Console.WriteLine($"Value for key 'apple': {result}");

        /*  string key1 = "lemon";  
          Console.WriteLine($"Value for key 'lemon': {myDictionary[key1]}");  получили ошибку, что лимона нет в словаре
        */

       
        int value;
        if (myDictionary.TryGetValue("apple", out value))
        {
            Console.WriteLine($"Value for key 'apple': {value}");
        }

        foreach (var key2 in myDictionary.Keys)
        {
            Console.WriteLine($"'{key2}' : {myDictionary[key2]}");
        }
        

        // Итерация по парам ключ-значение
        PrintHelper.PrintCollection(myDictionary);

        // Удаление элемента по ключу
        myDictionary.Remove("cherry");

        // Выводим элементы после удаления
        Console.WriteLine("Elements after removal:");
        PrintHelper.PrintCollection(myDictionary);

        // Очистка словаря
        myDictionary.Clear();

        // Выводим элементы после очистки
        Console.WriteLine("Elements after clearing:");
        PrintHelper.PrintCollection(myDictionary);
    }
}