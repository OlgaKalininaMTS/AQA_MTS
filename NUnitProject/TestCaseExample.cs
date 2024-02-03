using NUnit.Framework.Interfaces;

namespace NUnitTest;

public class TestCaseExample
{
    [Test(Description = "Домашняя работа. задание 1")]

  

    [TestCase(6, 2, 3)]   // набор данных
    [TestCase(-8, -2, -3)]
    [TestCase(10, 5, 0)]
    public void Test1(int x, int y, int result)
    {
        Assert.That(Calc.Div(x, y), Is.EqualTo(result));
    }
    
    [TestCase(1, 2, ExpectedResult = 3)]   // ExpectedResult -результат выполнения метода
    [TestCase(-1, -2, ExpectedResult = -3)]
    [TestCase(0, 0, ExpectedResult = 0)]

    public int Test2(int x, int y)
    {
        return Calc.Div(x, y);
    }
    
 
    
}