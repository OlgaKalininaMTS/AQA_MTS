using OpenQA.Selenium;

namespace PageObjectSimple.Pages
{
    public class ProductsPage : BasePage
    {
        private static string END_POINT = "inventory.html";
        
        // Описание элементов
        private static readonly By SidebarProjectsAddButtonBy = By.Id("inventory_container");
       // private static readonly By BasketInputBy = By.Id("shopping_cart_container");
        private static readonly By AddProductButtonBy = By.Id("add-to-cart-sauce-labs-onesie");
        private static By CartBadge = By.ClassName("shopping_cart_badge");
        private static readonly By RemoveProductButtonBy = By.Id("remove-sauce-labs-onesie");

        public ProductsPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement SidebarProjectsAddButton => Driver.FindElement(SidebarProjectsAddButtonBy);
        public IWebElement СheckingСart => WaitsHelper.WaitForExists(CartBadge);
        //public IWebElement СheckingСartClick => СheckingСart.Click();
        public IWebElement AddProductButton => WaitsHelper.WaitForExists(AddProductButtonBy);
        public void AddProduct() => AddProductButton.Click();
        public IWebElement RemoveProductButton => WaitsHelper.WaitForExists(RemoveProductButtonBy);
        public void RemoveProduct() => RemoveProductButton.Click();
        public bool СheckingСartInvisible => WaitsHelper.WaitForElementInvisible(CartBadge);





        // public void GoToCat() => UserlInput.Click();


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

        

    }
}