using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace SeleniumBasic.Core;

public class SimpleDriver  // отвечает за создание нового экземпляра браузера
{
    public IWebDriver Driver  // тип IWebDriver
    {
        get
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); // путь к папке debug/reliase ПРАВИЛЬНО
        // string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName; // путь до директории
          // return new ChromeDriver(@"C:\Users\Olga\source\repos\AQA_MTS\SeleniumBasic\Resources\");  // путь до драйвера на моем пк

            //   Console.WriteLine(basePath);
            //    Console.WriteLine(path);


            return new ChromeDriver(basePath + @"\Resources\");  // более правильный 

        }
    }
}