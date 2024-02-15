using Allure.Net.Commons;
using NUnit.Allure.Attributes;


namespace Wrappers.Tests;

public class BddAllureTest1 : BaseTest
{
    [Test]
    public void Story3Test()
    {
        AllureApi.AddEpic("Web Interface");
        AllureApi.AddFeature("Essential feature");
        AllureApi.AddFeature("Integration feature");
        AllureApi.AddStory("Story3");

        Assert.That(true);
    }
}