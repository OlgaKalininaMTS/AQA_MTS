namespace LINQ;

public class DataAggregation
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");
        
        // Формирование более общего набора данных из двух простых - берем набор персонов и отелей и объединяем
        var queryResult =
            from hotel in _testObjectSet.List  // идем по списку отелей
            from person in hotel.Persons    // идем по списку персонов отелей
            select person;   // собираем всех персонов из всех отелей
        
        foreach (var i in queryResult)
        {
            Console.WriteLine($"Person's: Name - {i.Name}, Age: {i.Age}");
        }
    }
    
    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");
        
        var queryResult = _testObjectSet.List.SelectMany(hotel => hotel.Persons);  // сначала идем по листу, затем с помощью метода SelectMany идем по персонам отелей

        foreach (var i in queryResult)
        {
            Console.WriteLine($"Person's: Name - {i.Name}, Age: {i.Age}");
        }

    }
}