using OpenQA.Selenium;
using Wrappers.Elements;

namespace Wrappers.Pages
{
    public class LoginPage : BasePage
    {
        private static string END_POINT = "";

        // Описание элементов /локаторов
        private static readonly By EmailInputBy = By.Id("name");
        private static readonly By PswInputBy = By.Id("password");
        private static readonly By RememberMeCheckboxBy = By.Id("rememberme");
        private static readonly By LoginInButtonBy = By.Id("button_primary");
        //private static readonly By ErrorLabelBy = By.CssSelector("[data-testid='loginErrorText']");
        private static readonly By ErrorLabelBy = By.ClassName("loginpage-message-image loginpage-message ");


        // Инициализация класса
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return LoginInButton.Displayed && EmailInput.Displayed;
        }

        // Методы
        // Методы поиска элементов
        public IWebElement EmailInput => WaitsHelper.WaitForExists(EmailInputBy); // паттерн page object
        public IWebElement ErrorLabel => WaitsHelper.WaitForExists(ErrorLabelBy);
        public IWebElement PswInput => WaitsHelper.WaitForExists(PswInputBy);
        public IWebElement RememberMeCheckbox => WaitsHelper.WaitForExists(RememberMeCheckboxBy);
        // public IWebElement LoginInButton => WaitsHelper.WaitForExists(LoginInButtonBy);
        public Button LoginInButton => new Button(Driver, LoginInButtonBy);

        // Методы действий с элементами
        public void ClickLoginInButton() => LoginInButton.Click();

        // Методы получения свойств
        public string GetErrorLabelText() => ErrorLabel.Text.Trim();
    }
}