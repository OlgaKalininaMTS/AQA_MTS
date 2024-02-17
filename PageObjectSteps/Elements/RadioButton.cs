using OpenQA.Selenium;
using Wrappers.Helpers;
using Wrappers.Helpers.Configuration;

namespace Wrappers.Elements;

public class RadioButton
{
    private List<UIElement> _uiElements;
    private List<string> _values;

    /// <summary>
    /// ������ ������� ������ ������������ ������� name ��� ��������
    /// </summary>
    /// <param name="webDriver"></param>
    /// <param name="by"></param>
    public RadioButton(IWebDriver webDriver, By by)
    {
        _uiElements = new List<UIElement>();
        _values = new List<string>();

        WaitsHelper _waitsHelper = new WaitsHelper(webDriver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        foreach (var webElement in _waitsHelper.WaitForPresenceOfAllElementsLocatedBy(by))
        {
            UIElement uiElement = new UIElement(webDriver, webElement);
            _uiElements.Add(uiElement);
            _values.Add(uiElement.GetAttribute("value"));
        }
    }

    public RadioButton(IWebDriver webDriver, IWebElement webElement)
    {

    }

    public void SelectByIndex(int index)
    {
        if (index < _uiElements.Count)
        {
            _uiElements[index].Click();
        }
        else
        {
            throw new AssertionException("�������� ������");
        }
    }

    public void SelectByValue(string value)
    {
        _uiElements[_values.IndexOf(value)].Click();
    }

    public void SelectByText(string text)
    {

    }
}