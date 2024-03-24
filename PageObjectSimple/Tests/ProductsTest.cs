using OpenQA.Selenium;
using Allure_hw.Helpers.Configuration;
using Allure_hw.Pages;

namespace Allure_hw.Tests;   

public class ProductsTest : BaseTest
{
    [Test]
    public void SuccessfulAddProductTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin("standard_user", "secret_sauce");
        ProductsPage productsPage = new ProductsPage(Driver);
        productsPage.AddProduct();

        Assert.That(productsPage.СheckingСart.Text, Is.EqualTo("1"));
    }
    
    [Test]
    public void InvalidAddProductTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin("standard_user", "secret_sauce");
        ProductsPage productsPage = new ProductsPage(Driver);
        productsPage.AddProduct();
       
        productsPage.RemoveProduct();
         Assert.That(productsPage.СheckingСartInvisible);
    }
}
