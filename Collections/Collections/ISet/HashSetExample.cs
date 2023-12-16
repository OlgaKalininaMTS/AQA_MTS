using Collections.Helper;

namespace Collections.ISet;

public class HashSetExample
{
    public void Run()
    {
        // Создание HashSet для строк
        HashSet<string> uniqueNames = new HashSet<string>();
       // HashSet<string> uniqueNames = new HashSet<string>(16); можно задать размер


        // Добавление элементов
        uniqueNames.Add("Alice");
        uniqueNames.Add("Bob");
        uniqueNames.Add("Tom");
        uniqueNames.Add("Ivan");
        uniqueNames.Add("Alice"); // Этот элемент не добавится, так как "Alice" уже существует

        // Вывод элементов
        Console.WriteLine("Unique Names:");
        PrintHelper.PrintCollection(uniqueNames);
        
        // Проверка наличия элемента
        bool containsBob = uniqueNames.Contains("Bob");
        Console.WriteLine($"Contains 'Bob': {containsBob}");

       
/*
        // Удаление элемента
        uniqueNames.Remove("Alice");

        // Вывод элементов после удаления
        Console.WriteLine("\nNames after removal:");
        PrintHelper.PrintCollection(uniqueNames);
*/
        HashSet<string> exceptNames = new HashSet<string>();
        exceptNames.Add("Alice");
        exceptNames.Add("Bob");
        exceptNames.Add("Tom1");

        //различие двух коллекций - 

       // uniqueNames.ExceptWith(exceptNames);
        var differ = uniqueNames.Except(exceptNames);

        // Вывод элементов после except
        Console.WriteLine("\nNames after except:");
        PrintHelper.PrintCollection(differ);
        /*
                uniqueNames.ExceptWith(exceptNames);
                // Вывод элементов после except
                Console.WriteLine("\nNames after ExceptWith:");
                PrintHelper.PrintCollection(uniqueNames);
        */
     
       // Вывод элементов после except
       var uniqueBoth = uniqueNames.Intersect(exceptNames);  //пересечение множеств - выведет только одинаковые элементы
        Console.WriteLine("\nNames after Intersect:");
        PrintHelper.PrintCollection(uniqueBoth);

        // объединение двух коллекций
        var uniqueBoth2 = uniqueNames.Union(exceptNames);
        Console.WriteLine("\nNames after Union:");
        PrintHelper.PrintCollection(uniqueBoth2);

        // propper
        uniqueNames.IsProperSubsetOf(exceptNames);
        Console.WriteLine($"IsProperSubsetOf :{uniqueNames.IsProperSubsetOf(uniqueNames)}");
        Console.WriteLine($"IsProperSupersetOf :{uniqueNames.IsProperSupersetOf(exceptNames)}");



    }
}