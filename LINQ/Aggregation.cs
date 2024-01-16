namespace LINQ;

public class Aggregation
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        // Aggregate - в Query не используется
        // Sum - в Query не используется
        // GroupBy
        var queryResult =
            from obj in _testObjectSet
            group obj by obj.Age;

        foreach (var item in queryResult)
        {
            Console.WriteLine($"{item.Key}");

            foreach (var subItem in item)
            {
                Console.WriteLine($"{subItem.Name} {subItem.Age}");
            }
        }

        var queryResult1 =
                from obj in _testObjectSet
                group obj by obj.Age
                into gen
                select new
                {
                    Age = gen.Key,
                    Count = gen.Count()
                };

        foreach(var item in queryResult1)
        {
            Console.WriteLine($"{item.Age} : {item.Count}");
        }
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        //PrintHelper.Print(queryResult, i => Console.WriteLine($"Except number: {i}"));


        // Aggregate
        var queryResult = _testIntSet.Aggregate((x, y) => x + y);  // метод Aggregate
        var queryResult1 = _testIntSet.Aggregate(10, (acc, i) => acc + i);  // 10 изначальное значение

        Console.WriteLine($"queryResult: {queryResult}");
        Console.WriteLine($"queryResult1: {queryResult1}");

        // Sum
        var queryResult3 = _testIntSet.Sum();
        var queryResult31 = _testObjectSet.Sum(person =>person.Age); // уточняем ,что именно в объектах надо суммировать
     
        queryResult3 = _testIntSet.Max();
        queryResult3 = _testIntSet.Min();
        var queryResult32 = _testIntSet.Average();


        Console.WriteLine($"queryResult: {queryResult3}");

        // GroupBy
        var queryResult4 = _testObjectSet.GroupBy(obj => obj.Age);

        foreach (var item in queryResult4)
        {
            Console.WriteLine($"{item.Key}");

            foreach (var subItem in item)
            {
                Console.WriteLine($"{subItem.Name} {subItem.Age}");
            }
        }
        
        var queryResult5 = _testObjectSet.GroupBy(obj => obj.Age)
            .Select(gen => new { Age = gen.Key, Count = gen.Count() });

        foreach(var item in queryResult5)
        {
            Console.WriteLine($"{item.Age} : {item.Count}");
        }
    }
}
