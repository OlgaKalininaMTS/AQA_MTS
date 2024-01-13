namespace LINQ;  // простой язык запросов

public class TestTask
{
    private TestObjectSet _testObjectSet = new();

    public void Solve()
    {
        List<Person> expectedList = new List<Person>();

        foreach (Person person in _testObjectSet)   // перебрать всех персонов и найти того, кому 45
        {
            if (person.Age == 45)
            {
                expectedList.Add(person);  // добавляем в ожидаемую коллекцию
            }
        }
        
        Console.WriteLine(expectedList.Count());
        
        Console.WriteLine(_testObjectSet.Where(obj => obj.Age == 45).Select(obj => obj).Count());  // краткое написание вышенаписанного
    }
}