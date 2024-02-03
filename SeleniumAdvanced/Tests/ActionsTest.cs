using System.Collections.ObjectModel;
using System.Data;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumBasic.Tests;

public class ActionsTest : BaseTest
{
    [Test]
    public void HoverTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/hovers");

        var actions = new Actions(Driver);

        var targetElements = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector(".figure"));

        actions
            .MoveToElement(targetElements, 10, 10)  // перейди на элемент и передвинься вправо-вниз по диагонали на 10
            .Click(WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("[href='/users/1']")))  // кликнуть элемент
            .Build()  // собрать объект
            .Perform();  // выполнить цепочку действий выше

        Assert.Multiple(() =>
        {
            Assert.That(WaitsHelper.WaitForElementInvisible(targetElements));
            
        });
    }
    /*
    public void HoverTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/hovers");

        var actions = new Actions(Driver);

        var targetElements = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("[alt='User Avatar']"));

        actions
            .MoveToElement(targetElements, 10, 10)  // перейди на элемент и передвинься вправо-вниз по диагонали на 10
            .Click(WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("[href='/users/1']")))  // кликнуть элемент
            .Build()  // собрать объект
            .Perform();  // выполнить цепочку действий выше

        Assert.Multiple(() =>
        {
            Assert.That(WaitsHelper.WaitForElementInvisible(targetElements));
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.TagName("h1")).Text, Is.EqualTo("Not Found"));
        });
    }
    */

    [Test]
    public void FileUploadTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

        var fileUploadPath = WaitsHelper.WaitForExists(By.Id("file-upload"));
        
        string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); // Получаем путь к исполняемому файлу (exe)

        // Конструируем путь к файлу внутри проекта
        string filePath = Path.Combine(assemblyPath, "Resources", "download.jpeg");
        Console.WriteLine(filePath);
        
        fileUploadPath.SendKeys(filePath);
        
        WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();
        Thread.Sleep(5000);
    }
}