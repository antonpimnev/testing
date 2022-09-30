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
        protected readonly By _signInButton = By.XPath("//a[text()='Вход']");
        protected readonly string _siteUrl = string.Empty;

        //Константы
        internal const string _correspondencePageUrl = "/Correspondence/Index";

        //вынести лучше в отдельный файл
        private const string _passInputQ = "1Qwerty!";
        internal const string _sedPageUrl = "/Ticket/Index";
        internal const string _futureDate = "01012999";

        public BaseTest()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(_siteUrl);
            driver.Manage().Window.Maximize();
        }

        //protected void AttachFile(By locator, string filePath)
        //{
        //    ClickOnElement(locator);

        //    // Ждём загрузки окна для выбора файла
        //    System.Threading.Thread.Sleep(1500);

        //    // На случай, если окно свёрнуто
        //    try
        //    {
        //        driver.Manage().Window.Position = new System.Drawing.Point(10, 10);
        //    }
        //    catch (OpenQA.Selenium.WebDriverException e)
        //    {

        //    }

        //    System.Windows.Forms.SendKeys.SendWait(filePath);
        //    System.Windows.Forms.SendKeys.SendWait("{ENTER}");
        //}

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
