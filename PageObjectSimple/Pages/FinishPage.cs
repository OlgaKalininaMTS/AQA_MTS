using OpenQA.Selenium;

namespace PageObjectSimple.Pages
{
    public class FinishPage : BasePage
    {
        private static string END_POINT = "checkout-complete.html";

        // Описание элементов
        private static readonly By FinishOpenBy = By.CssSelector("[class=complete-header]");

        public FinishPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement FinishOpen => WaitsHelper.WaitForExists(FinishOpenBy);

        public override bool IsPageOpened()
        {
            {
                return FinishOpen.Text.Trim().Equals("Thank you for your order!");
            }
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

    }
}