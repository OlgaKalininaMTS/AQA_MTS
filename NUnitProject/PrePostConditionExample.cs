namespace NUnitProject;

public class PrePostConditionExample
{
    private int i = 0;

    [OneTimeSetUp]   // выполняется один раз перед всем тестовым набором, данный метод наследуется
    public void OnetimeSetup()
    {
      //  Console.WriteLine($"{this}: OneTimeSetUp...");  // без параметра
        Console.WriteLine($"{this}: OneTimeSetUp... {++i}");
    }

    [SetUp]  // метод выполняется перед каждым тестовым методом, данный метод наследуется
    public void Setup()
    {
       // Console.WriteLine($"{this}: SetUp...");
        Console.WriteLine($"{this}: SetUp... {++i}");
    }

    [Test]
    public void Test1()
    {
       // Console.WriteLine($"{this}: Test1...");
        Console.WriteLine($"{this}: Test1... {++i}");
    }

    [Test]
    public void Test2()
    {
        Console.WriteLine($"{this}: Test2... {++i}");
    }

    [Test]
    public void Test11()
    {
        Console.WriteLine($"{this}: Test11... {++i}");
    }

    [TearDown]  // выполняется перед каждым тестовым методом
    public void TearDown()
    {
       // Console.WriteLine($"{this}: TearDown...");
        Console.WriteLine($"{this}: TearDown... {++i}");
    }

    [OneTimeTearDown]  // выполняется один раз после всем тестовым набором
    public void FinishTests()
    {
      //  Console.WriteLine($"{this}: OneTimeTearDown...");
        Console.WriteLine($"{this}: OneTimeTearDown... {++i}");
    }
}