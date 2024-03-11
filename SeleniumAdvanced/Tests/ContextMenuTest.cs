using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;


namespace SeleniumAdvanced.Tests;

public class ContextMenuTest : BaseTest
{
    [Test]
    public void ContextMenu()
    {
        Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/context_menu");

        var targetElements = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("hot-spot"));

        var actions = new Actions(Driver);

        actions
            .MoveToElement(targetElements, 15, 15)
            .ContextClick(targetElements)
            .Build()
            .Perform();

        IAlert alert = Driver.SwitchTo().Alert();

        Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));

        alert.Accept();
    }
}