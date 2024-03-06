using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBasic.Core;

namespace SeleniumBasic.Tests;


/// ///////////////////////////////////// Домашняя работа по Selenium.Basic. Задание 2 "Калькулятор ламината"


public class FirstTest2 : BaseTest  // Калькулятор ламината
{
    [Test]
    public void Laminate()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");
      //  Thread.Sleep(5000);

        IWebElement lenghtRoom = Driver.FindElement(By.Id("ln_room_id"));
        lenghtRoom.Clear();
        lenghtRoom.SendKeys("648");
        Thread.Sleep(1000);
        
        IWebElement widthRoom = Driver.FindElement(By.Id("wd_room_id"));
        widthRoom.Clear();
        widthRoom.SendKeys("650");
        Thread.Sleep(1000);

        IWebElement lenghtDie = Driver.FindElement(By.Id("ln_lam_id"));
        lenghtDie.Clear();
        lenghtDie.SendKeys("1295");
        Thread.Sleep(1000);

        IWebElement widthDie = Driver.FindElement(By.Id("wd_lam_id"));
        widthDie.Clear();
        widthDie.SendKeys("192");
        Thread.Sleep(1000);

        IWebElement quantityDie = Driver.FindElement(By.Id("n_packing"));
        quantityDie.Clear();
        quantityDie.SendKeys("6");
        Thread.Sleep(1000);

        IWebElement areaPacking = Driver.FindElement(By.Id("area"));
        areaPacking.Clear();
        areaPacking.SendKeys("1.49");
        Thread.Sleep(1000);

        IWebElement layingDirection = Driver.FindElement(By.Id("direction-laminate-id2"));
        layingDirection.Click();
        Thread.Sleep(1000);

        IWebElement installationMethod = Driver.FindElement(By.Id("laying_method_laminate"));
         SelectElement installationMethodDropdown = new SelectElement(installationMethod);
         installationMethodDropdown.SelectByText("со смещением на 1/2 длины");
         Thread.Sleep(1000);

        /* не заполняется для способа укладки "со смещением на 1/2 длины"
        IWebElement MinimumCuttingLength = Driver.FindElement(By.Id("min_length_segment_id"));
        MinimumCuttingLength.SendKeys(Keys.Backspace);
        MinimumCuttingLength.SendKeys("285");
        Thread.Sleep(1000);
        */

        IWebElement DistanceWalls = Driver.FindElement(By.Id("indent_walls_id"));
        DistanceWalls.SendKeys(Keys.Backspace);
        DistanceWalls.SendKeys("7");
        Thread.Sleep(1000);

        IWebElement countButton = Driver.FindElement(By.Id("btn_calculate"));
        countButton.Click();
        Thread.Sleep(3000);

        IWebElement RequiredLaminateDies = Driver.FindElement(By.XPath("//div[@class='calc-result']//div[1]//span"));
        Assert.That(RequiredLaminateDies.Text, Is.EqualTo("186"));

        IWebElement laminatePackages = Driver.FindElement(By.XPath("//div[@class='calc-result']//div[2]//span"));
        Assert.That(laminatePackages.Text, Is.EqualTo("31"));       
    }
}
