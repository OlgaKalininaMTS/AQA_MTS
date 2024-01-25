using Microsoft.Playwright;
using NUnitTest.Core;
using OpenQA.Selenium;

namespace NUnitTest.Tests;

[TestFixture]
public class WebDriverTest
{
    [Test]
    public void SimpleDriverTest()
    {
        IWebDriver webDriver = new SimpleDriver().Driver;


        // webDriver.Close(); //закрывает текущую закладку браузера

        webDriver.Manage().Window.Maximize();  // размеры окна браузера
        webDriver.Navigate().GoToUrl("http://www.gismeteo.ru//");
        webDriver.Quit(); // закрывает процесс/сессию диспетчере задач


    }

    [Test]
    public void AdvancedDriverTest()
    {
        IWebDriver webDriver = new AdvancedDriver().GetChromeDriver();
        webDriver.Manage().Window.Maximize();  // размеры окна браузера
        webDriver.Navigate().GoToUrl("http://www.gismeteo.ru//");
        webDriver.Quit(); // закрывает процесс/сессию диспетчере задач
    }

    [Test]
    public void FactoryDriverTest()
    {
        IWebDriver webDriver = new Browser().Driver!;
        webDriver.Manage().Window.Maximize();  // размеры окна браузера
        webDriver.Navigate().GoToUrl("http://www.gismeteo.ru//");
        webDriver.Quit(); // закрывает процесс/сессию диспетчере задач
    }
}