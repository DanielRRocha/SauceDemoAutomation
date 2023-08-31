using OpenQA.Selenium;
using SauceDemoAutomation.Hooks;

namespace SauceDemoAutomation.Pages
{
    internal class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public IWebElement productsTitle => driver.FindElement(By.XPath("//span[text()='Products']"));
    }
}
