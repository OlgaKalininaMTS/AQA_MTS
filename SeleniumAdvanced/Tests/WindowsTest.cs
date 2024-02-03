using OpenQA.Selenium;

namespace SeleniumBasic.Tests;

public class WindowsTest : BaseTest
{
    [Test]
    public void NewTabTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/windows");

        String originalWindow = Driver.CurrentWindowHandle;  // на какой закладке находимся, куда потом возвращаться
        
        Driver.FindElement(By.LinkText("Click Here")).Click();  

        var windowHandlesSet = Driver.WindowHandles;  // значение окон-закладок

        Driver.SwitchTo().Window(windowHandlesSet[1]);  // переключаемся на следующую закладку

        Thread.Sleep(3000);
        Assert.That(Driver.FindElement(By.TagName("h3")).Text, Is.EqualTo("New Window"));  // проверка, что новая закладка открылась

        Driver.Close();  // закрывает текущую закладку
        
        Thread.Sleep(3000);
        Driver.SwitchTo().Window(originalWindow);  // создать новую вкладку и переключиться на нее
        Assert.IsTrue(Driver.FindElement(By.LinkText("Click Here")).Displayed);  // получим ошибку, т.к. не вернулись на исходную закладку
        

    }
}