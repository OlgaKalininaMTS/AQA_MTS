using System.Collections.ObjectModel;
using System.Data;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvanced.Tests;

public class ContextMenuTest : BaseTest
{
    [Test]
    public void HoverTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/context_menu");


        var targetElements = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("hot-spot"));
       
        var actions = new Actions(Driver);
        
        actions
            .MoveToElement(targetElements, 15, 15)  // перейди на элемент и передвинься вправо-вниз по диагонали на 10
            .Click(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("hot-spot")))  // кликнуть элемент
            .Build()  // собрать объект
            .Perform();  // выполнить цепочку действий выше 

        IAlert alert = Driver.SwitchTo().Alert();

        Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));

        alert.Accept();
        
    }
    
}