using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.Tests;

public class SecondTest : BaseTest
{

    [Test]
    public void ValidateIKTCalculationTest1()
    {
        Driver.Navigate().GoToUrl("https://clinic-cvetkov.ru/company/kalkulyator-imt/");
        IWebElement heightInput = Driver.FindElement(By.Name("height"));  // рост
        IWebElement weightInput = Driver.FindElement(By.Name("weight"));  // вес, Input показываем что в него можно ввести значение
        IWebElement calcbutton = Driver.FindElement(By.Id("calc-mass-c"));

        heightInput.SendKeys("183");
        weightInput.SendKeys("58");
        calcbutton.Click();

        Thread.Sleep(2000);
        IWebElement result = Driver.FindElement(By.Id("imt-result"));
        Assert.That(result.Text, Is.EqualTo("17.3 - Недостаточная (дефицит) масса тела"));
    }
    
}