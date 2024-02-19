using NUnit.Framework;
using SeleniumBasic.Core;
using OpenQA.Selenium;
using SeleniumBasic.Utilites.Configuration;

namespace SeleniumBasic.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]

public class BaseTest  // инициализация и закрытие драйвера
{
    protected IWebDriver Driver { get; set; }  // свойство с 2 параметрами

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver!;   // свойствую присваиваем значение драйвера
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}