using OpenQA.Selenium;
using SauceDemoAutomation.Hooks;

namespace SauceDemoAutomation.Pages
{
    internal class HomePage
    {
        private IWebDriver driver;
        public HomePage()
        {
            driver = TestInitialize.GetDriver();
        }

        public IWebElement productsTitle => driver.FindElement(By.XPath("//span[text()='Products']"));
    }
}
