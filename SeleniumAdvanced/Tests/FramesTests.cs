using OpenQA.Selenium;

namespace SeleniumAdvanced.Tests;

public class FramesTests : BaseTest
{
    [Test]
    public void FrameTest() {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/frames");

        Driver.FindElement(By.LinkText("iFrame")).Click();
        Driver.SwitchTo().Frame("mce_0_ifr");
        Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.ClassName("mce-content-body")).Text, Is.EqualTo("Your content goes here."));
    }
}