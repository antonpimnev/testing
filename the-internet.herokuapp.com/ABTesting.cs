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
    public class ABTesting : BaseTest, IDisposable
    {
        [TestMethod]
        public void ABTesting1()
        {
            By _abTesting1 = By.XPath("//a[contains(text(),'A/B Testing')]");
            By _abTestingExpected = By.XPath("//p[contains(text(),'Also known as split testing. This is a way in whic')]");

            ClickOnElement(_abTesting1);
            bool result = FindElement(_abTestingExpected).Displayed;
            Assert.IsNotNull(result);
        }
    }
}

