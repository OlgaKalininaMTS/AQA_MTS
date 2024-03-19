using OpenQA.Selenium;
using PageObjectSimple.Helpers;

namespace PageObjectSimple.Pages
{
    public class YourCartPage : BasePage
    {
        private static string END_POINT = "cart.html";

        // Описание элементов
        private static readonly By TitleBy2 = By.ClassName("title");
        private static readonly By OpenCartBy = By.ClassName("cart_footer");
        private static readonly By CheckoutButtonBy = By.Id("checkout");
       
        public YourCartPage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)
        {
        }       

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        // Методы
        public IWebElement OpenCart => Driver.FindElement(OpenCartBy);
        public IWebElement CheckoutButton => WaitsHelper.WaitForExists(CheckoutButtonBy);
        public void ClickCheckoutButton() => CheckoutButton.Click();
     
        public override bool IsPageOpened()
        {
            try
            {
                return OpenCart.Displayed;

            }
            catch (Exception)
            {
                return false;
            }
        }       
    }
}