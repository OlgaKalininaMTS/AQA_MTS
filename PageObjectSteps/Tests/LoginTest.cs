using Wrappers_hw.Helpers.Configuration;
using Wrappers_hw.Pages;
using Wrappers_hw.Steps;
using Wrappers_hw.Tests;

namespace Wrappers_hw.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        LoginPage _loginPage = new LoginPage(Driver);
        _loginPage.EmailInput.SendKeys(Configurator.AppSettings.Username);
        _loginPage.PswInput.SendKeys(Configurator.AppSettings.Password);
        _loginPage.ClickLoginInButton();

        DashboardPage dashboardPage = new DashboardPage(Driver);

        Assert.That(dashboardPage.IsPageOpened);
    }

    [Test]
    public void SuccessfulLoginTest1()
    {
        UserSteps userSteps = new UserSteps(Driver);
        DashboardPage dashboardPage = userSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(dashboardPage.IsPageOpened);
    }

    //[Test]
    public void InvalidUsernameLoginTest()
    {
        // Проверка
        Assert.That(
            new UserSteps(Driver)
                .IncorrectLogin("ssdd", "")
                .GetErrorLabelText(),
            Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
    }
}