namespace NUnitTest;

//[TestFixture]  //
[TestFixture, Category("Example")]  // можно написать так

public class AttributesExample
{
    private int x;
    private int i = 0;

    [Test(Description = "Tests for Math Operations")]   // Description отобразится во внешнем отчете
    public void DemoTest()
    {
        Console.WriteLine($"{this}: DemoTest... {x++}");
    }
    
    [Test, Category("Example1")]  // расстановка категорий
    public void BigTest()
    {
        Console.WriteLine($"{this}: BigTest... {x++}");
    }
    
    [Test, Ignore("Ignoring these tests for now.")]  // тест кот надо игнорить(не проходить) с указанием причины
    public void AlphaTest()
    {
        Console.WriteLine($"{this}: AlphaTest... {x++}");
    }
    
    [Test, Order(1)]  // порядковый номер прохождения тестов
    public void ZTest()
    {
        Console.WriteLine($"{this}: ZTest... {x++}");
    }
    
    [Test, Order(2)]
    public void XTest()
    {
        Console.WriteLine($"{this}: XTest... {x++}");
    }
    
    [Test, Order(2)]
    [Author("Jane Doe", "jane.doe@example.com")]  // у этого теста есть автор
    [Author("Another Developer", "email@example.com")]
    public void AuthorTest()
    {
        Console.WriteLine($"{this}: AuthorTest... {x++}");
    }
    
    [Test, Repeat(5)]   // тест выполняется несколько раз (5)

    public void RepeatTest()
    {
        Console.WriteLine($"{this}: RepeatTest... ");
    }
    
    [Test,Retry(3)]
     // если тест провалился, то повторить запуск (3) раз 
    public void RetryTest()
    {
        Console.WriteLine($"{this}: RetryTest... {++i}");
        if (i == 3) Assert.Pass();  // не показывает все попытки
        else Assert.Fail();
    }

    [Test, MaxTime(2000)]  // быстродействие работы системы - тест должен быть выполнен за (200) времени если не успел то упал
    public void TimedTest()
    {
        Thread.Sleep(1000); // 1 сек
    }
    
    [Test]
    public void RandomValueTest(
        [Random(1, 10, 2)] double numberDouble)  // рандомная переменная от -1 до 1 и выполнить 2 раза
    {                                                // {x++} в каком порядке выполнялся рандом
        // public Random(<T> min, <T> max, int count);
        Console.WriteLine($"{this}: RandomAndValuesTest... {numberDouble} {x++}");
    }

    [Test]
    public void RandomAndValuesTest(  
        [Values(1, 2, 3)] int numberInt,    
        [Random(-1.0, 1.0, 2)] double numberDouble)  // рандомная переменная от -1 до 1 и выполнить 2 раза
    {                                                // {x++} в каком порядке выполнялся рандом
        // public Random(<T> min, <T> max, int count);
        Console.WriteLine($"{this}: RandomAndValuesTest... {numberInt} {numberDouble} {x++}");
    }
    [Test]
    public void RangeValueTest([Range(1, 5, 2)] int numberNumber)
    {
         Console.WriteLine($"{this}: XTest... {numberNumber}");
    }

    [Test]
   public void RangeTest(
       [Values(1, 2, 3)] int numberInt,
       [Range(0.2, 0.6, 0.2)] double numberDouble)
   {
       // public RangeAttribute(<T> from, <T> to);
       // public RangeAttribute(<T> from, <T> to, <T> step);
       Console.WriteLine($"{this}: XTest... {numberInt} {numberDouble}");
   }
   
    [Test]
    public void AllValuesTest(
        [Random(1,10,5)] int randomNumber,
        [Range(1,5,2)] int rangeNumber,
        [Values(1,5,2)] int valuesNumber)
    {
        Console.WriteLine($"{this}: AllValuesTest... {randomNumber} {x++}");
        Console.WriteLine($"{this}: AllValuesTest... {rangeNumber} {x++}");
        Console.WriteLine($"{this}: AllValuesTest... {valuesNumber} {x++}");
    }

     
   [Test, Combinatorial] // Генерирует все возможные пары, используется по умолчанию, можно не писать
   public void CombinatorialTest(
       [Values(1, 2, 3)] int number,
       [Values("A", "B")] string text)
   {
       Console.WriteLine($"{this}: XTest... {number} {text}");
   }

    
   [Test, Pairwise]
   public void PairwiseTest(
       [Values("a", "b", "c")] string a,
       [Values("+", "-")] string b,
       [Values("x", "y")] string c)
   {
       Console.WriteLine("{0} {1} {2}", a, b, c);
   }
    
   // Property
   [Test, Property("Severity", "Critical")]  // навешиваем на тест свойство -  "имя, значение"
   public void PropertyTest()
   {
       Console.WriteLine($"{this}: PropertyTest... {TestContext.CurrentContext.Test.Properties.Get("Severity")}");
    }                                               // 
    
       [Test, Severity(SeverityLevel.Minor)]
       public void AdvancedPropertyTest()
       { Console.WriteLine($"{this}: PropertyTest... {TestContext.CurrentContext.Test.Properties.Get("Severity")}"); }
       
}