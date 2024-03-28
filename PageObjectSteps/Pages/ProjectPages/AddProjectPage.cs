using OpenQA.Selenium;

namespace Wrappers_hw.Pages.ProjectPages;

public class AddProjectPage : ProjectBasePage
{
    private static string END_POINT = "index.php?/admin/projects/add";

    // Описание элементов
    private static readonly By TitleAddProjectBy = By.ClassName("page_title");
    private static readonly By AddButtonBy = By.Id("name");
    private static readonly By SaveCheckboxBy = By.Id("show_announcement");

    public AddProjectPage(IWebDriver driver) : base(driver)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return TitleAddProject.Text.Trim().Equals("Add Project");
    }

    // Атомарные Методы
    public IWebElement TitleAddProject => WaitsHelper.WaitForExists(TitleAddProjectBy);
    public IWebElement AddButton => Driver.FindElement(AddButtonBy);
    public IWebElement SaveCheckbox => Driver.FindElement(SaveCheckboxBy);
}