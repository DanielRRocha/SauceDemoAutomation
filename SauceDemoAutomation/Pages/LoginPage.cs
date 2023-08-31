using Dynamitey;
using OpenQA.Selenium;
using SauceDemoAutomation.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Pages
{
    internal class LoginPage
    {
        private IWebDriver driver;
        public LoginPage()
        {
            driver = TestInitialize.GetDriver();
        }

        public IWebElement userName => driver.FindElement(By.Id("user-name"));
        public IWebElement password => driver.FindElement(By.Id("password"));
        public IWebElement loginButon => driver.FindElement(By.Id("login-button"));
    }
}
