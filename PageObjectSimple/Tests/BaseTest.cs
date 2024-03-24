using System.Text;
using Allure_hw.Core;
using Allure_hw.Helpers;
using Allure_hw.Helpers.Configuration;
using Allure.Net.Commons;
using Allure_hw.Steps;
using NUnit.Allure.Core;
using OpenQA.Selenium;

namespace Allure_hw.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
[AllureNUnit]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    //protected UserSteps UserSteps;
    protected AllureBaseSteps AllureBaseSteps;

    [OneTimeSetUp]
    public static void GlobalSetup()
    {
        AllureLifecycle.Instance.CleanupResultDirectory();
    }

    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        AllureBaseSteps = new AllureBaseSteps(Driver);

        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
        {
            Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            byte[] screenshotBytes = screenshot.AsByteArray;

            AllureLifecycle.Instance.AddAttachment("Screenshot", "image/png", screenshotBytes);            
        }
        Driver.Quit();
    }
}