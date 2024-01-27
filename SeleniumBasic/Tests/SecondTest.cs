using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitTest.Tests;

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
    /*
    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
        Driver.SwitchTo().Frame(1);
        
        IWebElement selectWebElement = Driver.FindElement(By.Id("cr-size"));
        SelectElement selectSex = new SelectElement(selectWebElement);
        
        selectSex.SelectByIndex(1);
        Thread.Sleep(2000);
        
        selectSex.SelectByValue("mm");
        Thread.Sleep(2000);
        
        selectSex.SelectByText("мг/дл");
        Thread.Sleep(2000);
    }
    */
}