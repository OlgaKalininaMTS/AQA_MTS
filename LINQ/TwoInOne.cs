namespace LINQ;

public class TwoInOne
{
    private TestIntSet _testIntSet = new TestIntSet();
    
    public void run()
    {
        

        // Query Syntax + Method Syntax
        Console.WriteLine("Two in One");

        // Count    количество получившихся данных, результат целочисленное число
        int countResult =
            (from number in _testIntSet
             where number % 2 != 0
                select number).Count();

        Console.WriteLine($"{countResult}");

        int maxResult =
            (from number in _testIntSet
             where number % 2 == 0
                select number).Max();

        Console.WriteLine($"{maxResult}");
    }
}
