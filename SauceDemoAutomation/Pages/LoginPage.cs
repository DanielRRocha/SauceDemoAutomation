using OpenQA.Selenium;
using SauceDemoAutomation.Hooks;

namespace SauceDemoAutomation.Pages
{
    internal class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public IWebElement userName => driver.FindElement(By.Id("user-name"));
        public IWebElement password => driver.FindElement(By.Id("password"));
        public IWebElement loginButon => driver.FindElement(By.Id("login-button"));
    }
}
