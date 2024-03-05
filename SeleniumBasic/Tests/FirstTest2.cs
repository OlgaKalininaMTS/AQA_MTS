using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBasic.Core;

namespace SeleniumBasic.Tests;

public class FirstTest2 : BaseTest
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

      // sendKeys(Keys.Chord(Keys.Control, "a", Keys.Delete))

      //   Driver.FindElement(By.Id("min_length_segment_id")).SendKeys(Keys.Chord(Keys.Control, "a", Keys.Delete));
       // MinimumCuttingLength.Actio
      //  MinimumCuttingLength.SendKeys("350");
      //  Thread.Sleep(1000);

        /* IWebElement distanceWalls = Driver.FindElement(By.Id("indent_walls_id"));
         distanceWalls.Clear();
         distanceWalls.SendKeys("5");
         Thread.Sleep(1000);
        
        IWebElement indent = Driver.FindElement(By.Id("indent_walls_id"));
        indent.SendKeys(Keys.Control + "a");
        indent.SendKeys(Keys.Delete);
        indent.SendKeys("12");
        */
        /*  

          IWebElement selectRace = Driver.FindElement(By.Id("race"));
          SelectElement selectElementRace = new SelectElement(selectRace);
          selectElementRace.SelectByValue("O");
          Thread.Sleep(1000);

          IWebElement mass = Driver.FindElement(By.Id("mass"));
          mass.SendKeys("60");
          Thread.Sleep(1000);

          IWebElement grow = Driver.FindElement(By.Id("grow"));
          grow.SendKeys("156");
          Thread.Sleep(1000);

          IWebElement countButton = Driver.FindElement(By.XPath("//button[text()='Рассчитать']"));
          countButton.Click();
          Thread.Sleep(2000);


          IWebElement resultMdrd = Driver.FindElement(By.Id("mdrd_res"));
          Assert.That(resultMdrd.Text, Is.EqualTo("64.11"));

          IWebElement resultCkd_epi = Driver.FindElement(By.Id("ckd_epi_res"));
          Assert.That(resultCkd_epi.Text, Is.EqualTo("72.55"));

          IWebElement resultCge = Driver.FindElement(By.Id("cge_res"));
          Assert.That(resultCge.Text, Is.EqualTo("77.95"));

          IWebElement resultsChwartz = Driver.FindElement(By.Id("schwartz_res"));
          Assert.That(resultsChwartz.Text, Is.EqualTo("78"));
        */
        //Console.WriteLine(Driver.FindElement(By.ClassName("calc-result")).Text);
    }
}
