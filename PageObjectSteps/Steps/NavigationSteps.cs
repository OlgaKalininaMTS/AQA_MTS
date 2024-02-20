
using OpenQA.Selenium;
using ChainOfInvocations.Pages;
using ChainOfInvocations.Pages.ProjectPages;

namespace ChainOfInvocations.Steps;

public class NavigationSteps(IWebDriver driver) : BaseSteps(driver)
{
    // �����������
    public DashboardPage SuccessfulLogin(string username, string password)
    {
        return Login<DashboardPage>(username, password);
    }

    public LoginPage IncorrectLogin(string username, string password)
    {
        return Login<LoginPage>(username, password);
    }

    private T Login<T>(string username, string password) where T : BasePage
    {
        LoginPage = new LoginPage(Driver);
        LoginPage.EmailInput.SendKeys(username);
        LoginPage.PswInput.SendKeys(password);
        LoginPage.LoginInButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }
}