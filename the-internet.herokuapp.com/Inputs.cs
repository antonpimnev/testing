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
    public class Inputs : BaseTest, IDisposable
    {
        [TestMethod]
        public void Inputs1()
        {
            By _inputs1 = By.XPath("//a[contains(text(),'Inputs')]");
            By _input = By.XPath("//input[@type='number']");

            ClickOnElement(_inputs1);
            Thread.Sleep(2000);

            ClickOnElement(_input).SendKeys(1 + Keys.ArrowDown + Keys.ArrowDown + ',' +9 +'e');

            //TODO
            //WebElement result = (WebElement)driver.FindElement(_input);
            //String result1 = result.GetAttribute("value");
            //int result = driver.FindElement(_input).;
            //Assert.AreEqual(until+1, result);
        }
    }
}

