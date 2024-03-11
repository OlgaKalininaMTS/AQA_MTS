using System.Collections.ObjectModel;
using System.Data;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvanced.Tests;

public class FileUploadTest : BaseTest
{
    [Test]
    public void FileUpl()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

        var fileUploadPath = WaitsHelper.WaitForExists(By.Id("file-upload"));

        string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); // Получаем путь к исполняемому файлу (exe)

        // Конструируем путь к файлу внутри проекта
        string filePath = Path.Combine(assemblyPath, "Resources", "Shelt.jpeg");
        Console.WriteLine(filePath);

        fileUploadPath.SendKeys(filePath);

        WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();
        Thread.Sleep(5000);
    }
    
}