using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitTest.Tests;

public class FirstTest : BaseTest
{

    [Test]
    public void ValidateIKTCalculationTest()
    {
        Driver.Navigate().GoToUrl("https://clinic-cvetkov.ru/company/kalkulyator-imt/");
        Thread.Sleep(3000);

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
    
    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
        Driver.SwitchTo().Frame(1); // переключаемся в iFrame1
        
        IWebElement selectDropdown = Driver.FindElement(By.Id("cr-size"));
        SelectElement selectElement = new SelectElement(selectDropdown);

        selectElement.SelectByIndex(1);  // коллекцию нумеруются с нуля ,поэтому выбираем слуд значение
        Thread.Sleep(2000);

        selectElement.SelectByValue("mm");  // выбираем значение "mm"
        Thread.Sleep(2000);

        selectElement.SelectByText("мкмоль/л");
        Thread.Sleep(2000);
    }
    
}