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
    public class EntryAd : BaseTest, IDisposable
    {
        [TestMethod]
        public void EntryAd1()
        {
            By _entryAd1 = By.XPath("//a[contains(text(),'Entry Ad')]");
            By _entryAdClose = By.XPath("//p[contains(text(),'Close')]");

            ClickOnElement(_entryAd1);
            Thread.Sleep(2000);

            ClickOnElement(_entryAdClose);
            Thread.Sleep(2000);

            driver.Navigate().Refresh();
            Thread.Sleep(2000);
            bool result = driver.FindElement(_entryAdClose).Displayed;

            Assert.IsFalse(result);
        }

    }
}

