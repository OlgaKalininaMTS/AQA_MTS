using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBasic.Core;

namespace SeleniumBasic.Tests;

public class FirstTest : BaseTest
{
    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");

        //Thread.Sleep(3000);
        Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@src]")));

        IWebElement age = Driver.FindElement(By.Id("age"));
        age.SendKeys("18");
        Thread.Sleep(1000);

        IWebElement selectDropdownSex = Driver.FindElement(By.Id("sex"));
        SelectElement selectElementSex = new SelectElement(selectDropdownSex);
        selectElementSex.SelectByValue("F");
        Thread.Sleep(1000);

        IWebElement cr = Driver.FindElement(By.Id("cr"));
        cr.SendKeys("98");
        Thread.Sleep(1000);

        IWebElement selectDropdown = Driver.FindElement(By.Id("cr-size"));
        SelectElement selectElement = new SelectElement(selectDropdown);
        selectElement.SelectByValue("mcm");
        Thread.Sleep(1000);

        IWebElement selectRace = Driver.FindElement(By.Id("race"));
        SelectElement selectElementRace = new SelectElement(selectRace);
        selectElementRace.SelectByValue("O");
        Thread.Sleep(1000);

        IWebElement mass = Driver.FindElement(By.Id("mass"));
        mass.SendKeys("60");
        Thread.Sleep(1000);

        IWebElement grow = Driver.FindElement(By.Id("grow"));
        grow.SendKeys("156");
        Thread.Sleep(1000);

        IWebElement countButton = Driver.FindElement(By.XPath("//button[text()='Рассчитать']"));
        countButton.Click();
        Thread.Sleep(2000);


        IWebElement resultMdrd = Driver.FindElement(By.Id("mdrd_res"));
        Assert.That(resultMdrd.Text, Is.EqualTo("64.11"));

        IWebElement resultCkd_epi = Driver.FindElement(By.Id("ckd_epi_res"));
        Assert.That(resultCkd_epi.Text, Is.EqualTo("72.55"));

        IWebElement resultCge = Driver.FindElement(By.Id("cge_res"));
        Assert.That(resultCge.Text, Is.EqualTo("77.95"));

        IWebElement resultsChwartz = Driver.FindElement(By.Id("schwartz_res")); 
        Assert.That(resultsChwartz.Text, Is.EqualTo("78"));
    }


}
