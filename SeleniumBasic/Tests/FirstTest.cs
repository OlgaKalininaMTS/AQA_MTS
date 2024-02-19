using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.Tests;

public class FirstTest : BaseTest
{

    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
        Driver.SwitchTo().Frame(1); // переключаемся в iFrame1

        IWebElement selectDropdown = Driver.FindElement(By.Id("cr-size"));
        SelectElement selectElement = new SelectElement(selectDropdown);

        selectElement.SelectByIndex(1);  // коллекцию нумеруются с нуля ,поэтому выбираем след значение
        Thread.Sleep(2000);

        selectElement.SelectByValue("mm");  // выбираем значение "mm"
        Thread.Sleep(2000);

        selectElement.SelectByText("мкмоль/л");
        Thread.Sleep(2000);
    }

}