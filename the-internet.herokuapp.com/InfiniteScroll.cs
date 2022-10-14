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
    public class InfiniteScroll : BaseTest, IDisposable
    {
        [TestMethod]
        public void InfiniteScroll1()
        {
            By _infiniteScroll1 = By.XPath("//a[contains(text(),'Infinite Scroll')]");
            By _infiniteScroll2 = By.XPath("//h3[contains(text(),'Infinite Scroll')]");
            By _infiniteScrollParagraph = By.XPath("//div[@class='jscroll-added']");

            ClickOnElement(_infiniteScroll1);
            Thread.Sleep(2000);

            int until = driver.FindElements(_infiniteScrollParagraph).Count();

            IWebElement header = driver.FindElement(_infiniteScroll2);
            int deltaY = header.Location.Y;
            new Actions(driver)
                .ScrollByAmount(2300, deltaY)
                .Perform();

            int result = driver.FindElements(_infiniteScrollParagraph).Count();
            Assert.AreEqual(until+1, result);
        }
    }
}

