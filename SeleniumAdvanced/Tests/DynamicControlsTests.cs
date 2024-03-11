using OpenQA.Selenium;

namespace SeleniumAdvanced.Tests;

public class DynamicControlsTests : BaseTest
{
    [Test]
    public void InfoAlertTest()
    {
        Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_controls");

        var ACheckbox = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("#checkbox"));

        Driver.FindElement(By.XPath("//button[. = 'Remove']")).Click();

        Assert.Multiple(() =>
        {
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's gone!"));
            Assert.That(WaitsHelper.WaitForElementInvisible(ACheckbox));
        });

        IWebElement input = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("[style='width: 30%;']"));
        Assert.That(!input.Enabled);

        Driver.FindElement(By.XPath("//button[. = 'Enable']")).Click();
        
        Assert.Multiple(() =>
        {
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's enabled!"));
            Assert.That(input.Enabled);
        });
    }

}