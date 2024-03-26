using OpenQA.Selenium;
using Wrappers_hw.Elements;
using Wrappers_hw.Helpers;
using Wrappers_hw.Pages;

namespace Wrappers_hw.Pages;

public class DashboardPage : BasePage
{
    private static string END_POINT = "index.php?/dashboard";
    //private static string END_POINT = "index.php?/admin/projects/overview";


    // Описание элементов
    private static readonly By TitleLabelBy = By.ClassName("page_title");
    private static readonly By AddProjectButtonBy = By.Id("sidebar-projects-add");


    // Инициализация класса
    public DashboardPage(IWebDriver driver) : base(driver)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return TitleLabel.Text.Trim().Equals("All Projects");
    }

    // Атомарные Методы
    public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
    public Button AddProjectButton => new(Driver, AddProjectButtonBy);
}