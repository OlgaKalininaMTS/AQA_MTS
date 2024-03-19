using OpenQA.Selenium;

namespace PageObjectSimple.Pages
{
    public class CheckoutInformationPage : BasePage
    {
        private static string END_POINT = "checkout-step-one.html";

        // Описание элементов
        private static readonly By OpenCheckoutBy = By.ClassName("checkout_buttons");
        private static readonly By FirstNameBy = By.Id("first-name");
        private static readonly By LastNametBy = By.Id("last-name");
        private static readonly By PostalCodeBy = By.Id("postal-code");
        private static readonly By ContinueBy = By.Id("continue");



        public CheckoutInformationPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement OpenCheckout => Driver.FindElement(OpenCheckoutBy);
        public IWebElement FirstName => WaitsHelper.WaitForExists(FirstNameBy);
        public IWebElement LastName => WaitsHelper.WaitForExists(LastNametBy);
        public IWebElement PostalCode => WaitsHelper.WaitForExists(PostalCodeBy);
        public IWebElement Continue => WaitsHelper.WaitForExists(ContinueBy);

         public void GoContinue() => Continue.Click();


        public override bool IsPageOpened()
        {
            try
            {
                return OpenCheckout.Displayed;
                
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

        public void FirstLastZip(string firstname, string lastname, string code)
        {
            FirstName.SendKeys(firstname);
            LastName.SendKeys(lastname);
            PostalCode.SendKeys(code);
        }
    }
}