using BoDi;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

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

        [BeforeScenario(Order = 1)]
        public static void BeforeScenario()
        {
            Console.WriteLine("Initializing test");
            driver = new ChromeDriver();
            driver.Url = "https://www.saucedemo.com/";
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