using OpenQA.Selenium;

namespace PageObjectSimple.Pages
{
    public class LoginPage : BasePage
    {
        private static string END_POINT = "";
        
        // Описание элементов
        private static readonly By UserNameInputBy = By.Id("user-name");
        private static readonly By PasswordInputBy = By.Id("password");
        private static readonly By LoginInButtonBy = By.Id("login-button");
        private static readonly By ErrorLabelBy = By.ClassName("error-message-container");


        // Инициализация класса
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        
        // Методы
        public IWebElement UserlInput => WaitsHelper.WaitForExists(UserNameInputBy);  
        public IWebElement ErrorLabel => WaitsHelper.WaitForExists(ErrorLabelBy);  
        public IWebElement PasswordInput => WaitsHelper.WaitForExists(PasswordInputBy);
        public IWebElement LoginInButton => WaitsHelper.WaitForExists(LoginInButtonBy);

        // Комплексные
        public ProductsPage SuccessFulLogin(string username, string password)
        {
            UserlInput.SendKeys(username);
            PasswordInput.SendKeys(password);
            LoginInButton.Click();

            return new ProductsPage(Driver);
        }

        public LoginPage IncorrectLogin(string username, string password)
        {
            UserlInput.SendKeys(username);
            PasswordInput.SendKeys(password);
            LoginInButton.Click();

            return this;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return LoginInButton.Displayed && UserlInput.Displayed;
        }

        public void ClickLoginInButton() => LoginInButton.Click();
    }
}