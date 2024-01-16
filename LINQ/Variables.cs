namespace LINQ;

public class Variables
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");


        // Создание временных переменных
        var queryResult =
            from person in _testObjectSet
            let yearOfBirth = (DateTime.Now.Year - person.Age)  // let это объявление переменной yearOfBirth
            let flag = true
            select new  // создаем новую структуру
            {
                person.Name,   // можно написать Firstname=person.Name т.е. объявляем переменную с наименованием Firstname
                YearOfBirth = yearOfBirth,
                Flag = flag 
            };

        PrintHelper.Print(queryResult, item => Console.WriteLine($"person: {item}"));


        foreach (var i in queryResult)
        {
            Console.WriteLine($"Person's: Name - {i.Name}, Year of birth: {i.YearOfBirth}");
        }
    }
    
    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        // Создание временных переменных
        var queryResult = _testObjectSet
            //.Let
            .Select(person => new { person.Name, YearOfBirth = (DateTime.Now.Year - person.Age), Flag = true });  // воспользуемся командой .Select

         PrintHelper.Print(queryResult, item => Console.WriteLine($"Person: {item}"));


        var queryResult1 = _testObjectSet
            .Select(person => new { person.Name, YearOfBirth = (DateTime.Now.Year - person.Age) });
        
        
        PrintHelper.Print(queryResult, i => Console.WriteLine($"Person's: Name - {i.Name}, Year of birth: {i.YearOfBirth}"));
        PrintHelper.Print(queryResult1, i => Console.WriteLine($"Person's: Name - {i.Name}, Year of birth: {i.YearOfBirth}"));
        
        foreach (var i in queryResult)
        {
            Console.WriteLine($"Person's: Name - {i.Name}, Year of birth: {i.YearOfBirth}");
        }

    }
}