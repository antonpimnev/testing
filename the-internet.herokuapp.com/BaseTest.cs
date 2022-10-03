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
        protected readonly string _siteUrl = "http://the-internet.herokuapp.com";
        //protected readonly By _signInButton = By.XPath("//a[text()='Вход']");

        //Константы
        //internal const string _PageUrl = "/Correspondence/Index";

        //Вынести лучше в отдельный файл
        public const string password = "admin";
        public const string username = "admin";

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
