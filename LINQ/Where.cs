namespace LINQ;

public class Where
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        var queryResult =
            from number in _testIntSet
            where number % 2 == 0 && number > 5 // логическая операция отсева данных, можно использовать несколько условия (либо все условия в одном where либо в нескольких)
            select number;
        PrintHelper.Print(queryResult, i => Console.WriteLine($"Int: {i}"));

        var queryResult1 =
            from text in _testStringSet.List
            where text.StartsWith("A")  // строка начинается с буквы "А"
            select text;
        PrintHelper.Print(queryResult1, text => Console.WriteLine($"String: {text}"));


        var queryResult2 =
            from obj in _testObjectSet
            where obj.Age > 25  // возраст больше 25
            select obj;
        PrintHelper.Print(queryResult1, obj => Console.WriteLine($"Obj: {obj}"));


        foreach (var i in queryResult)
        {
            Console.WriteLine($"{i}");
        }

        foreach (var i in queryResult1)
        {
            Console.WriteLine($"{i}");
        }

        foreach (var i in queryResult2)
        {
            Console.WriteLine($"{i}");
        }
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        // public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        
        var methodResult = _testIntSet.Where(num => num % 2 == 0 && num > 5).Select(num => num);
        //var methodResult = testSet.Where<int>(num => num % 2 == 0).Select(number => number);
        PrintHelper.Print(methodResult, i => Console.WriteLine($"Int: {i}"));


        foreach (var i in methodResult)
        {
            Console.WriteLine($"{i}");
        }
        
        var methodResult1 = _testStringSet.List.Where(text => text.StartsWith("A"));
        PrintHelper.Print(methodResult1, text => Console.WriteLine($"String: {text}"));


        var methodResult2 = _testObjectSet.Where(item => item.Age > 25);
        PrintHelper.Print(methodResult1, item => Console.WriteLine($"Obj: {item}"));


        foreach (var i in methodResult1)
        {
            Console.WriteLine($"{i}");
        }

        foreach (var i in methodResult2)
        {
            Console.WriteLine($"{i}");
        }
    }
}