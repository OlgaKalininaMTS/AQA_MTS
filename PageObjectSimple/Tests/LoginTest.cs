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

        // Проверка 
        Assert.That(productsPage.IsPageOpened);
    }

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

    [Test]
    public void InvalidUsernameLoginLockedTest()
    {
        // Вид в стилистике Builder
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("locked_out_user", "secret_sauce")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }

    [Test]
    public void SuccessfulLoginProblemTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin("problem_user", "secret_sauce");
        ProductsPage productsPage = new ProductsPage(Driver);

        // Проверка 
        Assert.That(productsPage.IsPageOpened);
    }


}