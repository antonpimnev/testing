using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace the_internet.herokuapp.com
{
    [TestClass]
    public class MultipleWindows : BaseTest, IDisposable
    {
        [TestMethod]
        public void MultipleWindows1()
        {
            By _multipleWindows1 = By.XPath("//a[contains(text(),'Multiple Windows')]");
            By _multipleWindowsNew = By.XPath("//a[contains(text(),'Click Here')]");

            ClickOnElement(_multipleWindows1);
            Thread.Sleep(2000);

            ClickOnElement(_multipleWindowsNew);

            // https://www.selenium.dev/documentation/webdriver/interactions/windows/

            string originalWindow = driver.SwitchTo();

            //Assert.IsTrue(FindElement(_downloadsExcel).Displayed);
        }
    }
}

