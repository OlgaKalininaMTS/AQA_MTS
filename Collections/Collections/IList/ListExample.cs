using Collections.Helper;

namespace Collections.IList;

public class ListExample
{
    public void Run()
    {
        // Создаем список строк
        List<string> stringList = new List<string>();  // <> - пишем конкретный тип элементов для данной коллекции
        List<string> stringList1 = new List<string>(16);  // можем сразу написать, сколько элементов будет в коллекции

        Console.WriteLine($"Capacity1: {stringList.Capacity}");
         Console.WriteLine($"Capacity2: {stringList1.Capacity}");

        // Добавление элементов
        stringList.Add("Первый");
        stringList.Add("Второй");
        stringList.Add("Третий");
        stringList.Add("Третий");
        stringList.Add("Третий");
        stringList.AddRange(new[] { "Test", "Test1", "Test2" });  // добавление массива значений


        // Вставка элемента по индексу
        stringList.Insert(1, "Новый Второй");
        stringList.InsertRange(stringList.Count, new List<string>() { "Test4", "Test5" });

        // Вывод всех элементов
        Console.WriteLine("Элементы в списке:");
        PrintHelper.PrintCollection(stringList);
       
                // Получение элемента по индексу
     /*           string elementAtIndex = stringList[2];
                Console.WriteLine($"Элемент по индексу 2: {elementAtIndex}");

                // Поиск элемента по значению - проверка содержания элемента (проверка присутствия): возвращает ответ "Да/Нет"
                bool containsElement = stringList.Contains("Третий");
                Console.WriteLine($"Список содержит 'Третий': {containsElement}");
       */
                       // Сортировка элементов
                       stringList.Sort();
                       Console.WriteLine("Отсортированная коллекция:");
                       PrintHelper.PrintCollection(stringList);

                       // Бинарный поиск элемента (находит первое упоминание элемента)
                       // Перед использованием нужно отсортировать коллекцию, но и без сортировки будет работать 
                       var item = stringList.BinarySearch("Новый Второй");    // аналог indexOff
                       Console.WriteLine($"Бинарный поиск 'Новый Второй': {item}");

        // Поиск индекса элемента (находит первое упоминание элемента)
                       var index = stringList.IndexOf("Новый Второй");
                       Console.WriteLine($"Поиск индекса 'Новый Второй': {index}");
        
                            // Reverse элементов  - переворачивание коллекции (первый элемент становится последним)
                            stringList.Reverse();
                            Console.WriteLine("Перевернутая коллекция:");
                            PrintHelper.PrintCollection(stringList);
        
        // Reverse элементов  - переворачивание части коллекции (первый элемент становится последним)
        stringList.Reverse(1, stringList.Count - 1);
        Console.WriteLine("Перевернутая коллекция:");
        PrintHelper.PrintCollection(stringList);

       /* // Очистка полная
                            stringList.Clear();
                            Console.WriteLine($"Количество элементов после очистки: {stringList.Count}");
                            PrintHelper.PrintCollection(stringList);
        Console.WriteLine($"Capacity1: {stringList.Capacity}");
       */
        // копия части  коллекции - получение диапазона и копирование в массив
        var range = stringList.GetRange(4,5); // копия коллекции
        Console.WriteLine($"Часть коллекции: ");
        PrintHelper.PrintCollection(range);

        string[] part = new string[3]; 
        stringList.CopyTo(0, part, 1, 2); // копия коллекции выведенная в массиве
        Console.WriteLine($"Копия коллекции: ");
         PrintHelper.PrintCollection(part);
     
        // пример ForEach используется только для коллекций
        stringList.ForEach(p => Console.WriteLine(p));





        /*
                              // Удаление конкретного элемента на значению (первое упоминание)
                             // stringList.Remove("Третий");
                              bool result =  stringList.Remove("Третий");
                              Console.WriteLine($"Удаление элемента 'Третий': {index}");



                            // Удаление элемента по индексу
                             stringList.RemoveAt(0);

                            // Удаление группы элементов
                             
                            stringList.RemoveRange(0, 1);
      
                             // Вывод после удаления
                             Console.WriteLine("Элементы после удаления:");
                              PrintHelper.PrintCollection(stringList);
        */
    }
}