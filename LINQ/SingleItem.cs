namespace LINQ;

public class SingleItem
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");    

        // First            // нет механизма остановки, поэтому методы не работают
        var queryResult =
            from num in _testIntSet
            where (num == 4 || num == 6)
            select (num);
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        // First
        var queryResult = _testIntSet.Where(num => num == 4 || num == 6).First();  // перебор всей коллекции, а затем вывод результатов
        var queryResult1 = _testIntSet.First(num => num == 4 || num == 6);  // как только попадается результат он выводится, дальше метод не идет
        //var queryResult2 = _testIntSet.First(num => num == 12); // Exception
       


        Console.WriteLine($"queryResult: {queryResult}");
        Console.WriteLine($"queryResult1: {queryResult1}");
        //Console.WriteLine($"queryResult: {queryResult2}");
        
        // FirstOrDefault
        var queryResult3 = _testIntSet.FirstOrDefault(num => num == 4 || num == 6);
        var queryResult4 = _testIntSet.FirstOrDefault(num => num == 12);
        


        Console.WriteLine($"queryResult3: {queryResult3}");
        Console.WriteLine($"queryResult4: {queryResult4}");
        
        // 
        var queryResult5 = _testIntSet.Single(num => num == 4);  // проверяет: является ли значение единственным в коллекции
      // var queryResult6 = _testIntSet.Single(num => num == 4 || num == 6); // Exception т.к. оба числа есть в коллекции
        
        var queryResult8 = _testIntSet.SingleOrDefault(num => num == 4 || num == 6); //  Exception
        var queryResult7 = _testIntSet.SingleOrDefault(num => num == -4 || num == -6); // нет Exception


        Console.WriteLine($"queryResult5: {queryResult5}");
        //Console.WriteLine($"queryResult: {queryResult6}");
        Console.WriteLine($"queryResult7: {queryResult7}");




    }
}
