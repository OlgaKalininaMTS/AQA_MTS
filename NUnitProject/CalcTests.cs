using NUnit.Framework.Interfaces;

namespace NUnitTest;

[TestFixture, Category("Домашняя работа по теме NUnit")]
[Author("Olga Kalinina")]

public class CalcTests
{

    [OneTimeSetUp]
    public void OnetimeSetup()
    {
        Console.WriteLine("");
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.DivInt))]
    [Order(1), Description("Проверка деления Int")]
    public void CalcDivInt(int x, int y, int result)
    {
        Assert.That(x / y, Is.EqualTo(result));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.DivDouble))]
    [Order(2), Description("Проверка деления Double")]
    public void CalcDivDouble(double x, double y, double result)
    {
        Assert.That(x / y, Is.EqualTo(result));
    }

    [Test]
    [Order(3), Description("Проверка деления Int на 0")]
    public void CalcZeroInt()
    {

        Assert.Throws<DivideByZeroException>(() => Calc.DivInt(19, 0));
    }

    [Test]
    [Order(4), Description("Проверка деления Double на 0")]
    public void CalcZeroDouble()
    {
        if (double.IsInfinity((double)2 / 0))
            Assert.Pass("Деление на ноль произошло");
        else
            Assert.Fail("Ошибка деления на ноль");
    }

    [Test]
    [Order(5), Description("Проверка Int: равны ли указанные объекты")]
    public void TestCalcDivIntListEquality()
    {
        List<int> expectedList = new List<int> { 1, 2, 3 };
        List<int> actualList = new List<int> { 1, 2, 3 };

        CollectionAssert.AreEqual(expectedList, actualList, "Списки должны быть равными");
    }
        
    [TestCaseSource(typeof(TestData), nameof(TestData.DivInt))]
    [Order(6), Description("Проверка уникальности элементов Int")]
    public void CalcDivIntUniqueness(int x, int y, int result)
    {
        CollectionAssert.AllItemsAreUnique(TestData.DivInt, "В коллекции не должно быть повторяющихся элементов");
    }

    [Test]
    [Order(7), Description("Проверка сравнения элементов Int")]
    public void CalcDivIntComparison()
    {
        Assert.IsTrue(1 == 1);
    }

    [Test]
    [Order(8), Ignore("Проверка игнорирования")]
    public void CalcDivIntIgnore()
    {
        Assert.IsTrue(1 == 2);
    }

    [Test]
    [Order(9), Description("Рандомные числа Int")]
    public void CalcDivIntRund([Random(0, 48, 4)] int randNumber)
    {
        Console.WriteLine($"{this}: Рандомные числа Int... {randNumber}");
    }

    [Test]
    [Order(10), Description("Диапазон чисел Int")]
    public void CalcDivIntRange([Range(1, 15, 11)] int rangeNumber)
    {
        Console.WriteLine($"{this}: Диапазон чисел Int... {rangeNumber}");
    }

}