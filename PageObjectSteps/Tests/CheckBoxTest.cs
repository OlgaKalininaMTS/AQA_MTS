using OpenQA.Selenium;
using Wrappers_hw.Helpers.Configuration;
using Wrappers_hw.Pages;
using Wrappers_hw.Pages.ProjectPages;
using Wrappers_hw.Steps;
using Wrappers_hw.Tests;

namespace Wrappers_hw.Tests;

public class CheckBoxTest : BaseTest
{
    /*[Test]
    public void SuccessfulLoginTest()
    {
        LoginPage _loginPage = new LoginPage(Driver);
        _loginPage.EmailInput.SendKeys(Configurator.AppSettings.Username);
        _loginPage.PswInput.SendKeys(Configurator.AppSettings.Password);
        _loginPage.ClickLoginInButton();

        DashboardPage dashboardPage = new DashboardPage(Driver);

        Assert.That(dashboardPage.IsPageOpened);
    }*/

    [Test]
    public void SuccessfulLoginTest1()
    {
        UserSteps
             .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
             .AddProjectButton.Click();

        //Assert.That(AddProjectPage.IsPageOpened);

    }    
}