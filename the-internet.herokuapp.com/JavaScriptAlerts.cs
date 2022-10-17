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
using OpenQA.Selenium.Support.UI;

namespace the_internet.herokuapp.com
{
    [TestClass]
    public class JavaScriptAlerts : BaseTest, IDisposable
    {
        [TestMethod]
        public void JavaScriptAlerts1()
        {
            By _javaScriptAlerts1 = By.XPath("//a[contains(text(),'JavaScript Alerts')]");
            By _forJSAlert = By.XPath("//button[contains(text(),'Click for JS Alert')]");
            string expectedAlert = "I am a JS Alert";
            By _forJSConfirm = By.XPath("//button[contains(text(),'Click for JS Confirm')]");
            string expectedConfirm = "You clicked: Cancel";
            By _forJSResult = By.XPath("//p[@id='result']");
            By _forJSPrompt = By.XPath("//button[contains(text(),'Click for JS Prompt')]");
            string expectedPrompt = "You entered: Test"; //TODO: Добавить сращивание

            ClickOnElement(_javaScriptAlerts1);
            Thread.Sleep(2000);

            #region
            ClickOnElement(_forJSAlert);
            Thread.Sleep(1000);
            IAlert alert1 = driver.SwitchTo().Alert();
            string actualAlert = alert1.Text;
            Assert.AreEqual(expectedAlert, actualAlert);
            alert1.Accept();
            Thread.Sleep(2000);
            #endregion

            #region
            ClickOnElement(_forJSConfirm);
            Thread.Sleep(2000);
            IAlert alert2 = driver.SwitchTo().Alert();
            alert2.Dismiss();
            string actualConfirm = FindElement(_forJSResult).Text;
            Assert.AreEqual(expectedConfirm, actualConfirm);
            Thread.Sleep(2000);
            #endregion

            #region
            ClickOnElement(_forJSPrompt);
            Thread.Sleep(2000);
            IAlert alert3 = driver.SwitchTo().Alert();
            alert3.SendKeys("Test");
            alert3.Accept();
            string actualPrompt = FindElement(_forJSResult).Text;
            Assert.AreEqual(expectedPrompt, actualPrompt);
            #endregion
        }
    }
}

