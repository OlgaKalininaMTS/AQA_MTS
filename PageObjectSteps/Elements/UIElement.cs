using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Wrappers.Helpers;
using Wrappers.Helpers.Configuration;

namespace Wrappers.Elements

{
    public class UIElement : IWebElement
    {
        private IWebElement _webElement;
        private Actions _actions;
        protected WaitsHelper _waitHelper;

        private UIElement(IWebDriver webDriver)
        {
            _waitHelper = new WaitsHelper(webDriver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
            _actions = new Actions(webDriver);
        }

        public UIElement(IWebDriver webDriver, By @by) : this(webDriver)  //  
        {
            _webElement = _waitHelper.WaitForExists(by);
        }

        public UIElement(IWebDriver webDriver, IWebElement webElement) : this(webDriver)
        {
            _webElement = webElement;
        }

        public IWebElement FindElement(By @by)
        {
            return _webElement.FindElement(@by);  // берем конкретный блок элемента и ищем в нем
        }
        /*public UIElement FindUIElement(By @by)
        {
            return new UIElement.FindElement(_web);  // берем конкретный блок элемента и ищем в нем
        }*/

        public ReadOnlyCollection<IWebElement> FindElements(By @by)
        {
            return _webElement.FindElements(@by);   // берем конкретный блок элемента и ищем в нем
        }

        public void Clear()
        {
            _webElement.Clear();
        }

        public void SendKeys(string text)
        {
            _webElement.SendKeys(text);
        }

        public void Submit()
        {
            _webElement.Submit();
        }

        public void Click()
        {
            _webElement.Click();
          /*  try
            {
                _webElement.Click();
            }
            catch (ElementNotInteractableException)
            { 
            _actions
                    .MoveToElement(_webElement)
                    .
            }
          */
        }

        public string GetAttribute(string attributeName)
        {
            return _webElement.GetAttribute(attributeName);
        }

        public string GetDomAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetDomProperty(string propertyName)
        {
            return _webElement.GetDomProperty(propertyName);
        }

        public string GetCssValue(string propertyName)
        {
            return GetCssValue(propertyName);
        }

        public ISearchContext GetShadowRoot()
        {
            //throw new NotImplementedException();
            return GetShadowRoot();
        }

        public void Hover()
        {
            _actions.MoveToElement(_webElement).Build().Perform();
        }

        public string TagName => _webElement.TagName;

        public string Text => _webElement.Text;

        public bool Enabled => _webElement.Enabled;

        public bool Selected => _webElement.Selected;

        public Point Location => _webElement.Location;

        public Size Size => _webElement.Size;

        public bool Displayed => _webElement.Displayed;
    }
}