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
    public class ContextMenu : BaseTest, IDisposable
    {
        [TestMethod]
        public void ContextMenu1()
        {
            By _contextMenu1 = By.XPath("//a[contains(text(),'Context Menu')]");
            string expected = "You selected a context menu";

            ClickOnElement(_contextMenu1);
            Thread.Sleep(2000);

            IWebElement clickable = driver.FindElement(By.Id("hot-spot"));
            new Actions(driver)
                .ContextClick(clickable)
                .Perform();

            string text = driver.SwitchTo().Alert().Text;
            Assert.AreEqual(expected, text);
        }

    }
}

