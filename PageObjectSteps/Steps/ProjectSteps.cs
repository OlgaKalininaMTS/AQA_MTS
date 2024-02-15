using Allure.Pages;
using Allure.Pages.ProjectPages;
using OpenQA.Selenium;

namespace Allure.Steps;

public class ProjectsSteps : BaseSteps
{
    public ProjectsSteps(IWebDriver driver) : base(driver)
    {
        AddProjectPage addProjectPage = new AddProjectPage(Driver);
        DashboardPage dashboardPage = new DashboardPage(Driver);
    }

    public void AddProductToCart(List<string> Products)
    {
        new NavigationSteps(Driver).NavigateToProducts();


        // �������� �� ���� ��������� � ����� ��������� �� ��������
        // ������ ������ �������� ��� ������� ��������
    }

    public void CreateProject()
    {

    }

    public void UpdateProject()
    {

    }

    public void ReadProject()
    {

    }

    public void DeleteProject()
    {

    }
}