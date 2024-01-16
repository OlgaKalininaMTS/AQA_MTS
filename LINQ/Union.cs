namespace LINQ;

public class Union  // объединение
{
    private TestIntSet _testIntSet = new();
    List<int> blackList = new() { 3, 6, 8, -1, 12 };

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        // Объединение последовательностей    !!!!!!!!!!!!!!!!!!!!!!!!!!!!неправильно так делать!!!!!!!!!!!!!
        // Начать с метода
        var queryResult =
            ( from number in _testIntSet   // 
                select number)  // возвращаем туже самую коллекцию
            .Union(
                from number in blackList
                select number);
        PrintHelper.Print(queryResult, i => Console.WriteLine($"Number: {i}"));

        foreach (var i in queryResult)
        {
            Console.WriteLine($"Int: {i}");
        }
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        // Объединение последовательностей
        var queryResult = _testIntSet.Union(blackList);
        PrintHelper.Print(queryResult, i => Console.WriteLine($"Number: {i}"));  // значения второй коллекции добавились в конец, после главной коллекции

        foreach (var i in queryResult)
        {
            Console.WriteLine($"Int: {i}");
        }
    }
}