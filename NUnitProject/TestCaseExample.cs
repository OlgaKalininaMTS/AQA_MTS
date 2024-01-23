using NUnit.Framework.Interfaces;

namespace NUnitTest;

public class TestCaseExample
{
    [TestCase(1, 2, 3)]   // набор данных
    [TestCase(-1, -2, -3)]
    [TestCase(0, 0, 0)]
    public void Test1(int x, int y, int result)
    {
        Assert.That(Calc.Sum(x, y), Is.EqualTo(result));
    }
    
    [TestCase(1, 2, ExpectedResult = 3)]   // ExpectedResult -результат выполнения метода
    [TestCase(-1, -2, ExpectedResult = -3)]
    [TestCase(0, 0, ExpectedResult = 0)]

    public int Test2(int x, int y)
    {
        return Calc.Sum(x, y);
    }
    
    public static object[] DivideCases =   // коллекция
    {
        new object[] { 12, 3, 4 },
        new object[] { 12, 2, 6 },
        new object[] { 12, 4, 3 }
    };
        
    [TestCaseSource(nameof(DivideCases))]   // ждет на вход коллекцию, nameof - если данные находятся здесь же
    public void DivideTest(int n, int d, int result)
    {
        Assert.AreEqual(result, n / d);  // можно написать так, а лучше через That
       // Assert.That(n / d, Is.EqualTo(q)); в 4 версии unit надо писать так

    }

    [TestCaseSource(typeof(TestData), nameof(TestData.DivideCases))] // typeof откуда берем данные, nameof - какие данные берем
    public void ExternalDataTest(int n, int d, int q)
    {
        Assert.That(n / d, Is.EqualTo(q));
    }

}