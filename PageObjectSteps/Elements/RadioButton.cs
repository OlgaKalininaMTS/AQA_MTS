using OpenQA.Selenium;

namespace Wrappers.Elements
{
    public class RadioButton
    {
        private UIElement _uiElement;
        //private List<UIElement> _uIElements;

        public RadioButton(IWebDriver? driver, By by)
        {
            _uiElements = new List<UIElement>();

        }

        public void Click() => _uiElement.Click();
        public void Submit() => _uiElement.Submit();
        public string Text => _uiElement.Text;

        public bool Displayed => _uiElement.Displayed;
    }
}