namespace LINQ;

public class Except
{
    private TestIntSet _testIntSet = new();
   

    List<int> blackList = new() { -12, 3, -1, 3, 6, 8 , 12};



    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");
        
        // Разность последовательностей
        // Начать с метода
        var queryResult =
            from number in _testIntSet  // исходное множество
            where !blackList.Contains(number) // Contains - содержится, ! - частица "не" это не стандартное решение
            select number;

        PrintHelper.Print(queryResult, i => Console.WriteLine($"Except number: {i}"));

        foreach (var i in queryResult)
        {
            Console.WriteLine($"Int: {i}");
        }
    }
    
    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");
        
        // Разность последовательностей
        var queryResult = _testIntSet.Except(blackList);

        PrintHelper.Print(queryResult, item => Console.WriteLine($"Int: {item}"));


        foreach (var i in queryResult)
        {
            Console.WriteLine($"Int: {i}");
        }

    }
}