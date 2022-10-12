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
    public class DynamicLoading : BaseTest, IDisposable
    {
        [TestMethod]
        public void DynamicLoading1()
        {
            By _dynamicControls1 = By.XPath("//a[contains(text(),'Dynamic Loading')]");
            By _dynamicControls2 = By.XPath("//a[contains(text(),'Example 1: Element on page that is hidden')]");
            By _dynamicControls3 = By.XPath("//button[contains(text(),'Start')]");

            By _result1 = By.XPath("//div[@id='finish'] | //div[@style='']");
            By _result2 = By.XPath("//div[@id='finish']");

            ClickOnElement(_dynamicControls1);
            Thread.Sleep(2000);

            ClickOnElement(_dynamicControls2);
            Thread.Sleep(4000);
            ClickOnElement(_dynamicControls3);
            Thread.Sleep(5000);
            bool displayedResult = driver.FindElement(_result2).Displayed;

            Assert.IsNotNull(_result1);
            Assert.IsTrue(displayedResult);
        }

    }
}

