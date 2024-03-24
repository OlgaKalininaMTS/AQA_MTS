using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure_hw.Steps;

public class AllureBaseSteps
{
    protected IWebDriver Driver;

    public AllureBaseSteps(IWebDriver driver)
    {
        Driver = driver;
    }
}