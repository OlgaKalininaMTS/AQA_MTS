using OpenQA.Selenium;
using Wrappers_hw.Pages.ProjectPages;
using Wrappers_hw.Pages;
using Wrappers_hw.Steps;

namespace Wrappers_hw.Steps;

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