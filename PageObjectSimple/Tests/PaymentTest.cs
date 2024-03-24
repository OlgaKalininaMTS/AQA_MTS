using OpenQA.Selenium;
using Allure_hw.Helpers;
using Allure_hw.Helpers.Configuration;
using Allure_hw.Pages;
using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace Allure_hw.Tests;

public class PaymentTest : BaseTest
{
    [Test(Description = "Проверка успешной покупки товара")]
    [AllureSeverity(SeverityLevel.critical)]
    [AllureOwner("oakalinina")]
    public void PaymentSuccessfulTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin("standard_user", "secret_sauce");
        ProductsPage productsPage = new ProductsPage(Driver);
        productsPage.AddProduct();

        productsPage.СheckingСart.Click();
        YourCartPage yourCartPage = new YourCartPage(Driver);

        Assert.Multiple(() =>
        {
            Assert.That(yourCartPage.IsPageOpened);
            Assert.That(Driver.FindElement(By.LinkText("Sauce Labs Onesie")).Displayed); // проверили что нужный товар в корзине
        });

        yourCartPage.ClickCheckoutButton();

        CheckoutInformationPage checkoutInformationPage = new CheckoutInformationPage(Driver);
        Assert.That(checkoutInformationPage.IsPageOpened);

        checkoutInformationPage.FirstLastZip("Olga", "Kalinina", "123");
        checkoutInformationPage.GoContinue();

        CheckoutTwoPage checkoutTwoPage = new CheckoutTwoPage(Driver);
        Assert.Multiple(() =>
        {
            Assert.That(checkoutTwoPage.IsPageOpened);
            Assert.That(checkoutTwoPage.ItemTotal.Text, Is.EqualTo("Item total: $7.99"));
            Assert.That(checkoutTwoPage.Tax.Text, Is.EqualTo("Tax: $0.64"));
            Assert.That(checkoutTwoPage.Total.Text, Is.EqualTo("Total: $8.63"));
        });

        checkoutTwoPage.FinishButton();

        FinishPage finishPage = new FinishPage(Driver);
        Assert.That(finishPage.IsPageOpened);
    }
}
