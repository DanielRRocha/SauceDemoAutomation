using OpenQA.Selenium;
using SauceDemoAutomation.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
