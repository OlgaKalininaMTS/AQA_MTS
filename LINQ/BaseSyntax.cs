namespace LINQ;

public class BaseSyntax  // линкью работает только тогда, когда обращаемся к результирующему запросу
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    // Основной LINQ ситаксис  // синтаксис запросов
    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");
        
        IEnumerable<int> queryResult =
            from number in _testIntSet     // from "имя переменной" (ключевое слово-in) "источник данных": пройтись по всей коллекции TestIntSet и добавить в новую коллекцию _testIntSet
            select number;                 // select переменная

        foreach (var i in queryResult)   //
        {
            Console.WriteLine($"Int: {i}");
        }

        IEnumerable<string> queryResult1 =
            from text in _testStringSet.List  // обращаемся не к самой коллекции, а получить лист
            select text;
         PrintHelper.Print(queryResult1, s => Console.WriteLine($"String: {s}"));


        foreach (var i in queryResult1)
        {
            Console.WriteLine($"String: {i}");
        }
        
                IEnumerable<Person> queryResult2 =
                    from person in _testObjectSet
                    select person;
        PrintHelper.Print(queryResult2, obj => Console.WriteLine($"Person: {obj}"));


        foreach (var i in queryResult2)
                {
                    Console.WriteLine($"Person: {i.Name} {i.Age}");
                }
             
    }

    public void RunMethodSyntax()  // // синтаксис методов
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");
        
        IEnumerable<int> methodResult = _testIntSet.Select(number => number);  // используется лямбдавыражение намбер положить в намбер
        //IEnumerable<int> methodResult = testSet.Where(num => num > 5).Select(number => number);
        
      /*  foreach (var i in methodResult)
        {
            Console.WriteLine($"Int: {i}");
        }
       */
        PrintHelper.Print(methodResult, i => Console.WriteLine($"Int: {i}"));
        
        IEnumerable<string> methodResult1 = _testStringSet.List.Select(text => text + "!");
        PrintHelper.Print(methodResult1, s => Console.WriteLine($"String: {s}"));

        IEnumerable<Person> methodResult2 = _testObjectSet.Select(obj => obj);
        PrintHelper.Print(methodResult2, i => Console.WriteLine($"Person: {i.Name} {i.Age}"));
    }

    public void RunStringExtension()
    {
        // Метод расширения String
        string test = "test";
        Console.WriteLine($"Char: {test.GetChar(0)}");
    }
}