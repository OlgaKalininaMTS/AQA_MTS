using Allure_hw.Pages;
using Allure_hw.Helpers.Configuration;
using NUnit.Allure.Attributes;
using Allure.Net.Commons;

namespace Allure_hw.Tests;

public class LoginTest : BaseTest
{

    [Test(Description = "Проверка успешного логирования стандартного пользователя")]
    [AllureSeverity(SeverityLevel.normal)]
    [AllureOwner("oakalinina")]   
    public void SuccessfulLoginTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        ProductsPage productsPage = new ProductsPage(Driver);

        Assert.That(productsPage.IsPageOpened);
    }

    [Test(Description = "Проверка неуспешного логирования")]
    [AllureSeverity(SeverityLevel.critical)]
    [AllureOwner("oakalinina")]
    public void InvalidUsernameLoginTest()
    {
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("ssdd", "yyy")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
    }

    [Test(Description = "Проверка неуспешного логирования блокированного пользователя")]
    [AllureSeverity(SeverityLevel.normal)]
    [AllureOwner("oakalinina")]
    public void InvalidUsernameLoginLockedTest()
    {
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("locked_out_user", "secret_sauce")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }

    [Test(Description = "Проверка успешного логирования проблемного пользователя")]
    [AllureSeverity(SeverityLevel.normal)]
    [AllureOwner("oakalinina")]
    public void SuccessfulLoginProblemTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin("problem_user", "secret_sauce");
        ProductsPage productsPage = new ProductsPage(Driver);

        Assert.That(productsPage.IsPageOpened);
    }

    [Test(Description = "Проверка создания скриншота")]
    [AllureSeverity(SeverityLevel.critical)]
    [AllureOwner("oakalinina")]
    public void ScreenshortSuccessfulLoginTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin("standard_", "secret_sauce");
        ProductsPage productsPage = new ProductsPage(Driver);

        Assert.That(productsPage.IsPageOpened);
    }
}