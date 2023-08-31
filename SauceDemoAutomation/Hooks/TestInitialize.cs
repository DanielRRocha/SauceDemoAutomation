using System.Configuration;
using System.Net.NetworkInformation;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SauceDemoAutomation.Hooks
{
    [Binding]
    public sealed class TestInitialize
    {
        private static IWebDriver? driver;
        private static TestContext? testContext;

        public static IWebDriver? GetDriver()
        {
            return driver;
        }

        public static string? GetAppSettings(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static TestContext? GetTestContext()
        {
            return testContext;
        }

        [BeforeScenario(Order = 1)]
        public static void BeforeScenario()
        {
            Console.WriteLine("Initializing test");
            driver = new ChromeDriver();
            driver.Url = GetAppSettings("url");
            driver.Manage().Window.Maximize();
            testContext = TestContext.CurrentContext;
            Console.WriteLine($"Test Name: {testContext.Test.MethodName}");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Finishing test and closing driver");
            driver.Close();
        }
    }
}