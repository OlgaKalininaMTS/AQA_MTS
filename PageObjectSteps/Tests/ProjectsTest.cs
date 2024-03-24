using OpenQA.Selenium;
using Wrappers_hw.Elements;
using Wrappers_hw.Helpers.Configuration;
using Wrappers_hw.Pages.ProjectPages;
using Wrappers_hw.Steps;
using Wrappers_hw.Tests;

namespace Wrappers_hw.Tests;

public class ProjectsTest : BaseTest
{
    [Test]
    public void AddProjectCorrectTest()
    {
        UserSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
            .AddProjectButton.Click();

        AddProjectPage addProjectPage = new AddProjectPage(Driver);
        addProjectPage.ProjectTypeRadioButton.SelectByIndex(1);
        addProjectPage.ProjectTypeRadioButton.SelectByValue("3");
        addProjectPage.ProjectTypeRadioButton.SelectByText("Use a single repository for all cases (recommended)");
    }

    [Test]
    public void TmpTest()
    {
        UserSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Driver.Navigate().GoToUrl("https://ac0502.testrail.io/index.php?/admin/site_settings#");
        RadioButton tmpElement = new(Driver, By.Name("restore_backup"));

        tmpElement.SelectByIndex(3);
    }
}