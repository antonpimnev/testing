using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace the_internet.herokuapp.com
{
    [TestClass]
    public class BaseTest : IDisposable
    {
        internal IWebDriver driver;

        //Локаторы
        //protected readonly By _signInButton = By.XPath("//a[text()='Вход']");
        protected readonly string _siteUrl = "http://the-internet.herokuapp.com";

        //Константы
        //SiteUrl = "https://testing-i.cascadepro.online:8443"
        //internal const string _abPageUrl = "/Correspondence/Index";

        //вынести лучше в отдельный файл
        private const string _passInputQ = "1Qwerty!";

        public BaseTest()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(_siteUrl);
            driver.Manage().Window.Maximize();
        }

        public void GoToUrl(string pageUrl)
        {
            if (!pageUrl.StartsWith('/'))
            {
                pageUrl = $"/{pageUrl}";
            }
            driver.Navigate().GoToUrl($"{_siteUrl}{pageUrl}");
        }

        public IWebElement ClickOnElement(By locator, int timeoutSeconds = 10)
        {
            //var element = driver.FindElement(locator, timeoutSeconds);
            var element = driver.FindElement(locator);
            element.Click();

            return element;
        }

        public IWebElement FindElement(By locator, int timeoutSeconds = 10)
        {
            var element = driver.FindElement(locator, timeoutSeconds);

            return element;
        }

        public virtual void Dispose()
        {
            //driver.Quit();
        }
    }
}
