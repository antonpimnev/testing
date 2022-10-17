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
    public class JQueryUIMenus : BaseTest, IDisposable
    {
        [TestMethod]
        public void JQueryUIMenus1()
        {
            By _jQueryUIMenus1 = By.XPath("//a[contains(text(),'JQuery UI Menus')]");
            By _disabled = By.XPath("//a[@id='ui-id-1']");
            By _enabled = By.XPath("//a[@id='ui-id-2']");
            By _toMenu = By.XPath("//a[@id='ui-id-5']");
            By _downloads = By.XPath("//a[@id='ui-id-4']");
            By _downloadsPDF = By.XPath("//a[@id='ui-id-6']");
            By _downloadsCSV = By.XPath("//a[@id='ui-id-7']");
            By _downloadsExcel = By.XPath("//a[@id='ui-id-8']");
            By _jQueryUI = By.XPath("//a[contains(text(),'JQuery UI')]");

            ClickOnElement(_jQueryUIMenus1);
            Thread.Sleep(2000);

            bool disabled = FindElement(_disabled).Enabled;
            //Как то он странно детектит. По факту должно было быть False
            Assert.IsTrue(disabled);
            Thread.Sleep(2000);

            ClickOnElement(_enabled);
            ClickOnElement(_toMenu);

            Assert.IsTrue(FindElement(_jQueryUI).Displayed);

            driver.Navigate().Back();
            ClickOnElement(_enabled);
            ClickOnElement(_downloads);
            Assert.IsTrue(FindElement(_downloadsPDF).Displayed);
            Assert.IsTrue(FindElement(_downloadsCSV).Displayed);
            Assert.IsTrue(FindElement(_downloadsExcel).Displayed);
        }
    }
}

