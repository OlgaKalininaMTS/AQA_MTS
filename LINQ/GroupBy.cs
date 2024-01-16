namespace LINQ;

public class GroupBy
{
    private TestIntSet _testIntSet = new();
    private TestStringSet _testStringSet = new();
    private TestObjectSet _testObjectSet = new();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");


        var queryResult2 =
            from person in _testObjectSet
            group person by person.Age
           into result
            select new { GroupName = result.Key, Count = result.Count() };
        PrintHelper.Print(queryResult2, item => Console.WriteLine($"Person: {item}"));



        foreach (var i in queryResult2)
        {
            Console.WriteLine($"{i}");
        }
    }   
       
    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");
        
        var queryResult2 = _testObjectSet
                .GroupBy(person => person.Age)
                .Select(result => new {GroupName = result.Key, Count = result.Count()} );  // двухэтапная сортировка в объектах
        PrintHelper.Print(queryResult2, item => Console.WriteLine($"Person: {item}"));

      
       
        
       
    }
}