using Microsoft.Playwright;
using SeleniumBasic.Core;
using OpenQA.Selenium;

namespace SeleniumBasic.Tests;

[TestFixture]
public class WebDriverTest
{
    [Test]
    public void SimpleDriverTest()
    {
        IWebDriver webDriver = new SimpleDriver().Driver;


        // webDriver.Close(); //закрывает текущую закладку браузера

        webDriver.Manage().Window.Maximize();  // размеры окна браузера
                                               // webDriver.Navigate().GoToUrl("http://www.gismeteo.ru//");
        webDriver.Quit(); // закрывает процесс/сессию диспетчере задач


    }

    [Test]
    public void AdvancedDriverTest()
    {
        IWebDriver webDriver = new AdvancedDriver().GetChromeDriver();
        webDriver.Manage().Window.Maximize();  // размеры окна браузера
                                               //  webDriver.Navigate().GoToUrl("http://www.gismeteo.ru//");
        webDriver.Quit(); // закрывает процесс/сессию диспетчере задач
    }

    [Test]
    public void FactoryDriverTest()
    {
        IWebDriver webDriver = new Browser().Driver!;
        webDriver.Manage().Window.Maximize();  // размеры окна браузера
                                               //  webDriver.Navigate().GoToUrl("http://www.gismeteo.ru//");
        webDriver.Quit(); // закрывает процесс/сессию диспетчере задач
    }
}