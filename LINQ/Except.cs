namespace LINQ;

public class Except
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();


    private List<int> blackList = new() { -1, -3, 3, 6, 8, 12 };
    public List<Person> personBlackList = new List<Person>()
        {
        new Person("Michel", 23),
        new Person("Oleg", 23),
        new Person("Toma", 55),
    };


    public void RunQuerySyntax()
    {
        // Query Syntax    Основной LINQ ситаксис
        Console.WriteLine("Query Syntax");
        
        // Разность последовательностей
        // Начать с метода
        var queryResult =
            from number in _testIntSet  // исходное множество
            where !blackList.Contains(number) // Contains - содержится, ! - частица "не" это не стандартное решение
            select number;

        PrintHelper.Print(queryResult, item => Console.WriteLine($"Int: {item}"));

        foreach (var i in queryResult)
        {
            Console.WriteLine($"Int: {i}");
        }
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        var queryResult = _testIntSet.Except(blackList);

        var queryResult1 = _testObjectSet.Except(personBlackList);

        PrintHelper.Print(queryResult, item => Console.WriteLine($"Int: {item}"));
        PrintHelper.Print(queryResult1, item => Console.WriteLine($"Person: {item}"));


        foreach (var i in queryResult)
        {
            Console.WriteLine($"Int: {i}");
        }

    }
}