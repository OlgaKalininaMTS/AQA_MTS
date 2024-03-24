using OpenQA.Selenium;
using Wrappers_hw.Elements;
using Wrappers_hw.Helpers.Configuration;
using Wrappers_hw.Pages;
using Wrappers_hw.Steps;
using Wrappers_hw.Tests;

namespace Wrappers_hw.Tests;

public class TableTest : BaseTest
{
    [Test]
    public void AddProjectCorrectTest()
    {
        UserSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
            .AddProjectButton.Click();

        ProjectsPage projectsPage = new ProjectsPage(Driver, true);
        TableCell tableCell = projectsPage.ProjectsTable.GetCell("Project", "Test2", "Project");
        tableCell.GetLink().Click();
    }
}