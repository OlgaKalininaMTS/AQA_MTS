namespace LINQ;

public class Intersect  // оставить только то, что есть в обоих множествах
{
    private TestIntSet _testIntSet = new();
    List<int> blackList = new() { -1, -3, 3, 6, 8 , 12};
    
    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");
        
        // Пересечение последовательностей
        var queryResult =
            from number in _testIntSet
            where blackList.Contains(number) 
            select number;
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
        
        // Пересечение последовательностей
        var queryResult = _testIntSet.Intersect(blackList);
        PrintHelper.Print(queryResult, i => Console.WriteLine($"Number: {i}"));


        foreach (var i in queryResult)
        {
            Console.WriteLine($"Int: {i}");
        }

    }
}