using System.Collections;

namespace Collections.Helper;

public static class PrintHelper
{
    
    // Обычный вариант 1
    public static void PrintCollection(System.Collections.IList list)  //вызываем меод без создания экземпляра класса (надо только указать из какого класса хотим его вызвать)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    /*
        // Обычный вариант 2
        public static void PrintCollection(Dictionary<string, int> dictionary)
        {
            foreach (var pair in dictionary)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }
        }

        // Обычный вариант 3
        public static void PrintCollection(SortedDictionary<string, int> dictionary)
        {
            foreach (var pair in dictionary)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }
        }
        */

    // Общий метод для печати элементов IEnumerable
    public static void PrintCollection(IEnumerable collection)
    {
        foreach (var item in collection)
        {
            if (item is DictionaryEntry)
            {
                // Обработка случая словаря
                var entry = (DictionaryEntry)item;
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
            else
            {
                // Обработка других случаев
                Console.WriteLine(item);
            }
        }
    }
}