using OpenQA.Selenium;
using Allure_hw.Helpers.Configuration;
using Allure_hw.Pages;
using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace Allure_hw.Tests;   

public class ProductsTest : BaseTest
{
    [Test(Description = "Проверка добавления товара")]
    [AllureSeverity(SeverityLevel.critical)]
    [AllureOwner("oakalinina")]
    public void AddProductSuccessfulTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin("standard_user", "secret_sauce");
        ProductsPage productsPage = new ProductsPage(Driver);
        productsPage.AddProduct();

        Assert.That(productsPage.СheckingСart.Text, Is.EqualTo("1"));
    }

    [Test(Description = "Проверка удаления товара")]
    [AllureSeverity(SeverityLevel.critical)]
    [AllureOwner("oakalinina")]
    public void RemoveProductTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin("standard_user", "secret_sauce");
        ProductsPage productsPage = new ProductsPage(Driver);
        productsPage.AddProduct();
       
        productsPage.RemoveProduct();
         Assert.That(productsPage.СheckingСartInvisible);
    }
}
