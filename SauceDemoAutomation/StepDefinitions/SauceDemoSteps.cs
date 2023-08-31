using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SauceDemoAutomation.Hooks;
using SauceDemoAutomation.Pages;
using TechTalk.SpecFlow.Assist;

namespace SauceDemoAutomation.StepDefinitions
{
    [Binding]
    internal class SauceDemoSteps
    {

        private readonly ScenarioContext context;
        private static IWebDriver? driver;
        private WebDriverWait wait;
        private LoginPage loginPage;
        private HomePage homePage;

        public SauceDemoSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
            driver = TestInitialize.GetDriver();
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            loginPage  = new LoginPage();
            homePage = new HomePage();
        }

        [Given(@"I have access to login page")]
        public void GivenIHaveAccessToLoginPage()
        {
            wait.Until(x => loginPage.loginButon.Displayed && loginPage.loginButon.Enabled);
            Assert.IsTrue(loginPage.loginButon.Displayed);
        }

        [When(@"I make a login using this data")]
        public void WhenIMakeALoginUsingThisData(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            loginPage.userName.SendKeys(data.Login);
            loginPage.password.SendKeys(data.Password);
            loginPage.loginButon.Click();
        }

        [Then(@"I have access to home page")]
        public void ThenIHaveAccessToHomePage()
        {
            wait.Until(x => homePage.productsTitle.Displayed);
            Assert.IsTrue(homePage.productsTitle.Displayed);
        }
    }
}
