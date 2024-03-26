using OpenQA.Selenium;

namespace Wrappers_hw.Elements;

public class Checkbox
{
    private UIElement _uiElement;

    public Checkbox(IWebDriver webDriver, By by)
    {
        _uiElement = new UIElement(webDriver, by);
    }

    public Checkbox(IWebDriver webDriver, IWebElement webElement)
    {
        _uiElement = new UIElement(webDriver, webElement);
    }

    public void Click()
    {
        _uiElement.Click();
    }
}