using OpenQA.Selenium;
using PageObjectSimple.Pages;


namespace PageObjectSimple.Steps;

public class UserSteps : BaseStep
{
    private LoginPage _loginPage;

    public UserSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(Driver);
    }

    // Комплексные
    public DashboardPage SuccessfulLogin(string username, string password)
    {
        _loginPage.UserlInput.SendKeys(username);
        _loginPage.PasswordInput.SendKeys(password);
        _loginPage.ClickLoginInButton();

        return new DashboardPage(Driver);
    }

    public LoginPage IncorrectLogin(string username, string password)
    {
        _loginPage.UserlInput.SendKeys(username);
        _loginPage.PasswordInput.SendKeys(password);
        _loginPage.LoginInButton.Click();

        return _loginPage;
    }
}