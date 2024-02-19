using NUnit.Framework;
using SeleniumBasic.Core;
using OpenQA.Selenium;
using SeleniumBasic.Utilites.Configuration;

namespace SeleniumBasic.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]

public class BaseTest  // ������������� � �������� ��������
{
    protected IWebDriver Driver { get; set; }  // �������� � 2 �����������

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver!;   // ��������� ����������� �������� ��������
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}