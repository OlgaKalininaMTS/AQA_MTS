using PageObjectSimple.Helpers.Configuration;
using PageObjectSimple.Pages;
using PageObjectSimple.Steps;

namespace PageObjectSimple.Tests;

public class LoginTest : BaseTest
{
    
    [Test]
    public void SuccessfulLoginTest()
    {
        UserSteps userSteps = new UserSteps(Driver);
        DashboardPage dashboardPage = userSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(dashboardPage.IsPageOpened);
        

    }

    
    /* готов
    [Test]
    public void InvalidUsernameLoginTest()
    {
        // Вид в стилистике Builder
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("ssdd", "yyy")
                .ErrorLabel.Text.Trim(), 
            Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
    }
    */
}