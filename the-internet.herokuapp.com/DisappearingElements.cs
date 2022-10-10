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
    public class DisappearingElements : BaseTest, IDisposable
    {
        [TestMethod]
        public void DisappearingElements1()
        {
            By _disappearingElements1 = By.XPath("//a[contains(text(),'Disappearing Elements')]");
            By _disappearingElement1 = By.XPath("//a[contains(text(),'Gallery')]");

            ClickOnElement(_disappearingElements1);
            Thread.Sleep(2000);

            bool expected = driver.FindElement(_disappearingElement1).Displayed;
            Assert.IsTrue(expected);
        }

    }
}

