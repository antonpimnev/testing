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

        protected void AttachFile(By locator, string filePath)
        {
            ClickOnElement(locator);

            // Ждём загрузки окна для выбора файла
            System.Threading.Thread.Sleep(1500);

            // На случай, если окно свёрнуто
            try
            {
                driver.Manage().Window.Position = new System.Drawing.Point(10, 10);
            }
            catch (OpenQA.Selenium.WebDriverException e)
            {

            }

            System.Windows.Forms.SendKeys.SendWait(filePath);
            System.Windows.Forms.SendKeys.SendWait("{ENTER}");
        }

        public virtual void Dispose()
        {
            //driver.Quit();
        }
    }
}
