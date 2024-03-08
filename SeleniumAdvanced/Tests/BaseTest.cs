using OpenQA.Selenium;
using SeleniumAdvanced.Core;
using SeleniumAdvanced.Helpers;
using SeleniumAdvanced.Helpers.Configuration;

namespace SeleniumAdvanced.Tests;

//[Parallelizable(scope: ParallelScope.All)]
//[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }

}