using OpenQA.Selenium;
using Locators.Helpers.Configuration;

namespace Locators.Tests;

public class LocatorsHW : BaseTest
{
    [Test]
    public void BasicXPathSelectors()
    {
        Driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        // basicLocators

        Driver.FindElement(By.Id("user-name")).SendKeys(Configurator.AppSettings.Username);
        Driver.FindElement(By.Name("password")).SendKeys(Configurator.AppSettings.Password);
        Driver.FindElement(By.ClassName("login_credentials_wrap")).Click();
        Driver.FindElement(By.TagName("input")).Click();
        Driver.FindElement(By.LinkText("Sauce Labs Fleece Jacket")).Click();
        Driver.FindElement(By.PartialLinkText("Bolt"));

        // XPath
        
         Assert.That(Driver.FindElement(By.XPath("//input[@id='login-button']")).Displayed);
         Assert.That(Driver.FindElement(By.XPath("//div[text() = 'problem_user']")).Displayed);
         Assert.That(Driver.FindElement(By.XPath("//*[starts-with(@id, 'log')]")).Displayed);
         Assert.That(Driver.FindElement(By.XPath("//*[contains(@data-test,'login')]")).Displayed);
         Assert.That(Driver.FindElement(By.XPath("//h4/ancestor::div")).Displayed);
         Assert.That(Driver.FindElement(By.XPath("//div/descendant::h4")).Displayed);
         Assert.That(Driver.FindElement(By.XPath("//*[@class='form_group']/following::div")).Displayed);
         Assert.That(Driver.FindElement(By.XPath("//h4/parent::div")).Displayed);
         Assert.That(Driver.FindElement(By.XPath("//*[@class='login_credentials_wrap-inner']/preceding::div")).Displayed);
         Assert.That(Driver.FindElement(By.XPath("//input[@class='input_error form_input' and @type='text']")).Displayed);
        
        // CSS
        
        Assert.That(Driver.FindElement(By.CssSelector(".form_group")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector(".input_error.form_input")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector(".login_credentials_wrap .login_credentials_wrap-inner")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("#login-button")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("h4")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("div.login_password")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("[data-test='password']")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("[autocorrect~=off]")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("[data-test|=login-button]")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("[autocapitalize^=no]")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("[class$='tials']")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("[class*=error]")).Displayed);        
    }
}