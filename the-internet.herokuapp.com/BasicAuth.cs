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
    public class BasicAuth : BaseTest, IDisposable
    {
        public void handleAuth()
        {
            driver.Navigate().GoToUrl("https://" + username + ":" + password + "@" + "the-internet.herokuapp.com/basic_auth");
        }

        [TestMethod]
        public void BasicAuth1()
        {
            By _textCongrats = By.XPath("//p[contains(text(),'Congratulations! You must have the proper credentials')]");

            Thread.Sleep(2000);
            handleAuth();
            //driver.SwitchTo().Alert().SendKeys(username + Keys.Tab + password + Keys.Tab + Keys.Enter);
            Thread.Sleep(5000);
            var textCongrats = FindElement(_textCongrats).Text;
            String expected = "Congratulations! You must have the proper credentials.";
            Assert.AreEqual(expected, textCongrats.Trim());
        }
    }
}

