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
    public class Frames : BaseTest, IDisposable
    {
        [TestMethod]
        public void Frames1()
        {
            By _frames1 = By.XPath("//a[contains(text(),'Frames')]");
            By _frames2 = By.XPath("//a[contains(text(),'Nested Frames')]");
            By _frames3 = By.XPath("//frame[@src='/frame_left']");

            ClickOnElement(_frames1);
            Thread.Sleep(2000);
            ClickOnElement(_frames2);
            Thread.Sleep(2000);

            driver.SwitchTo().Frame(1);
            var result = driver.FindElement(_frames3);

            //driver.FindElement();
        }
    }
}

