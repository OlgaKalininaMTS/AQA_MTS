using OpenQA.Selenium;

namespace PageObjectSimple.Pages
{
    public class ProductsPage : BasePage
    {
        private static string END_POINT = "inventory.html";
        
        // Описание элементов
        private static readonly By SidebarProjectsAddButtonBy = By.Id("inventory_container");
        private static readonly By BasketInputBy = By.Id("shopping_cart_container");
        private static readonly By AddProductButtonBy = By.Id("add-to-cart-sauce-labs-backpack");
        private static By CartBadge = By.Id(".shopping_cart_badge");
        



        // Инициализация класса
        public ProductsPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }


        public ProductsPage(IWebDriver? driver) : base(driver, false)
        {
        }

        
        public override bool IsPageOpened()
        {
            try
            {
                return SidebarProjectsAddButton.Displayed;
                
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

        public IWebElement SidebarProjectsAddButton => Driver.FindElement(SidebarProjectsAddButtonBy);
        public IWebElement AddProductButton => WaitsHelper.WaitForExists(AddProductButtonBy);
        //public bool IsAddProductButtonDisplayed() => IsElementDisplayed(AddProductButtonBy);
        public void AddProduct() => AddProductButton.Click();
        public IWebElement UserlInput => WaitsHelper.WaitForExists(CartBadge);

    }
}