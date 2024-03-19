using OpenQA.Selenium;

namespace PageObjectSimple.Pages
{
    public class CheckoutTwoPage : BasePage
    {
        private static string END_POINT = "checkout-step-two.html";

        // Описание элементов
        private static readonly By CheckoutOverviewBy = By.ClassName("checkout_summary_container");
        private static readonly By ItemTotalBy = By.ClassName("summary_subtotal_label");
        private static readonly By TaxBy = By.ClassName("summary_tax_label");
        private static readonly By TotalBy = By.ClassName("summary_total_label");
        private static readonly By FinishBy = By.Id("finish");

        public CheckoutTwoPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement CheckoutOverview => Driver.FindElement(CheckoutOverviewBy);
        public IWebElement ItemTotal => WaitsHelper.WaitForExists(ItemTotalBy);
        public IWebElement Tax => WaitsHelper.WaitForExists(TaxBy);
        public IWebElement Total => WaitsHelper.WaitForExists(TotalBy);
        public IWebElement Finish => WaitsHelper.WaitForExists(FinishBy);
         public void FinishButton() => Finish.Click();

        public override bool IsPageOpened()
        {
            try
            {
                return CheckoutOverview.Displayed;
                
            }
            catch (Exception)
            {
                return false;
            }           
        }        

        protected override string GetEndpoint()
        {
            return END_POINT;
        }      

    }
}